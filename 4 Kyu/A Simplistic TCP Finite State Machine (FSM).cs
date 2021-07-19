public enum ProcessState
    {
        CLOSED,
        LISTEN,
        SYN_SENT,
        SYN_RCVD,
        ESTABLISHED,
        CLOSE_WAIT,
        LAST_ACK,
        FIN_WAIT_1,
        FIN_WAIT_2,
        CLOSING,
        TIME_WAIT
    }

    public enum Command
    {
        APP_PASSIVE_OPEN,
        APP_ACTIVE_OPEN,
        APP_SEND,
        APP_CLOSE,
        APP_TIMEOUT,
        RCV_SYN,
        RCV_ACK,
        RCV_SYN_ACK,
        RCV_FIN,
        RCV_FIN_ACK
    }

    public static class TCP
    {
        public static string TraverseStates(string[] events)
        {
            if (events.Any(e => !Enum.IsDefined(typeof(Command), e))) return "ERROR";
            var process = new Process();
            if (events.Length == 0) return process.CurrentState.ToString();
            try
            {
                foreach (var command in events)
                {
                    process.MoveNext((Command)Enum.Parse(typeof(Command), command));
                }
            }
            catch (Exception)
            {
                return "ERROR";
            }
            return process.CurrentState.ToString();
        }
    }

    public class Process
    {
        private class StateTransition
        {
            private readonly ProcessState _currentState;
            private readonly Command _command;

            public StateTransition(ProcessState currentState, Command command)
            {
                _currentState = currentState;
                _command = command;
            }

            public override int GetHashCode()
            {
                return 17 + (31 * _currentState.GetHashCode()) + (31 * _command.GetHashCode());
            }

            public override bool Equals(object obj)
            {
                return obj is StateTransition other && this._currentState == other._currentState && this._command == other._command;
            }
        }

        private readonly Dictionary<StateTransition, ProcessState> _transitions;
        public ProcessState CurrentState { get; private set; }

        public Process()
        {
            CurrentState = ProcessState.CLOSED;
            _transitions = new Dictionary<StateTransition, ProcessState>
            {
                { new StateTransition(ProcessState.CLOSED, Command.APP_PASSIVE_OPEN), ProcessState.LISTEN },
                { new StateTransition(ProcessState.CLOSED, Command.APP_ACTIVE_OPEN), ProcessState.SYN_SENT },
                { new StateTransition(ProcessState.LISTEN, Command.RCV_SYN), ProcessState.SYN_RCVD },
                { new StateTransition(ProcessState.LISTEN, Command.APP_SEND), ProcessState.SYN_SENT },
                { new StateTransition(ProcessState.LISTEN, Command.APP_CLOSE), ProcessState.CLOSED },
                { new StateTransition(ProcessState.SYN_RCVD, Command.APP_CLOSE), ProcessState.FIN_WAIT_1 },
                { new StateTransition(ProcessState.SYN_RCVD, Command.RCV_ACK), ProcessState.ESTABLISHED },
                { new StateTransition(ProcessState.SYN_SENT, Command.RCV_SYN), ProcessState.SYN_RCVD },
                { new StateTransition(ProcessState.SYN_SENT, Command.RCV_SYN_ACK), ProcessState.ESTABLISHED },
                { new StateTransition(ProcessState.SYN_SENT, Command.APP_CLOSE), ProcessState.CLOSED },
                { new StateTransition(ProcessState.ESTABLISHED, Command.APP_CLOSE), ProcessState.FIN_WAIT_1 },
                { new StateTransition(ProcessState.ESTABLISHED, Command.RCV_FIN), ProcessState.CLOSE_WAIT },
                { new StateTransition(ProcessState.FIN_WAIT_1, Command.RCV_FIN), ProcessState.CLOSING },
                { new StateTransition(ProcessState.FIN_WAIT_1, Command.RCV_FIN_ACK), ProcessState.TIME_WAIT },
                { new StateTransition(ProcessState.FIN_WAIT_1, Command.RCV_ACK), ProcessState.FIN_WAIT_2 },
                { new StateTransition(ProcessState.CLOSING, Command.RCV_ACK), ProcessState.TIME_WAIT },
                { new StateTransition(ProcessState.FIN_WAIT_2, Command.RCV_FIN), ProcessState.TIME_WAIT },
                { new StateTransition(ProcessState.TIME_WAIT, Command.APP_TIMEOUT), ProcessState.CLOSED },
                { new StateTransition(ProcessState.CLOSE_WAIT, Command.APP_CLOSE), ProcessState.LAST_ACK },
                { new StateTransition(ProcessState.LAST_ACK, Command.RCV_ACK), ProcessState.CLOSED }
            };
        }

        private ProcessState GetNext(Command command)
        {
            var transition = new StateTransition(CurrentState, command);
            if (!_transitions.TryGetValue(transition, out var nextState))
                throw new Exception($"Invalid transition: {CurrentState} -> {nameof(command)}");
            return nextState;
        }

        public ProcessState MoveNext(Command command)
        {
            CurrentState = GetNext(command);
            return CurrentState;
        }
    }