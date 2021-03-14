using System;
using System.Collections.Generic;
using System.Linq;

public enum Dir
{
    Up,
    Down
}

public class Rider
{
    public int PickupFloor { get; }
    public int Destination { get; }
    public Dir UpOrDown { get; }

    public Rider(int destination, int pickupFloor)
    {
        Destination = destination;
        PickupFloor = pickupFloor;
        UpOrDown = PickupFloor > Destination ? Dir.Down : Dir.Up;
    }
}

public class Lift
{
    private readonly Tuple<int, int> _floorRange;
    private List<int> _stopsList;
    private readonly int _maxCapacity;
    private List<Rider> _destinationList;
    private int _currentCapacity;
    public Dir CurrentDirection { get; private set; }
    public int CurrentFloor { get; set; }


    public Lift(int topFloor, int maxCapacity)
    {
        _floorRange = new Tuple<int, int>(0, topFloor);
        _stopsList = new List<int>();
        _destinationList = new List<Rider>();
        _maxCapacity = maxCapacity;
        _currentCapacity = 0;
        CurrentFloor = 0;
        CurrentDirection = Dir.Up;
    }

    public int NextStop(Dictionary<int, List<Rider>> building)
    {
        if (building.Sum(x => x.Value.Count) == 0 && _destinationList.Count == 0) return -1;
        if (CurrentDirection == Dir.Up && CurrentFloor == _floorRange.Item2) CurrentDirection = Dir.Down;
        if (CurrentDirection == Dir.Down && CurrentFloor == _floorRange.Item1) CurrentDirection = Dir.Up;

        switch (CurrentDirection)
        {
            case Dir.Up:
                return GoingUp(building);
            case Dir.Down:
                return GoingDown(building);
            default:
                return -1;
        }
    }

    private int GoingDown(Dictionary<int, List<Rider>> building)
    {
        for (int i = CurrentFloor - 1; i >= _floorRange.Item1; i--)
        {
            if (building[i].Any(x => x.UpOrDown == Dir.Down) ||
                _destinationList.Any(x => x.Destination == i))
            {
                return i;
            }
        }
        CurrentDirection = Dir.Up;
        for (int i = _floorRange.Item1; i < _floorRange.Item2; i++)
        {
            if (building[i].Any(x => x.UpOrDown == Dir.Up) ||
                _destinationList.Any(x => x.Destination == i))
            {
                return i;
            }
        }
        CurrentDirection = Dir.Down;
        for (int i = _floorRange.Item2; i > _floorRange.Item1; i--)
        {
            if (building[i].Any(x => x.UpOrDown == Dir.Down) ||
                _destinationList.Any(x => x.Destination == i))
            {
                return i;
            }
        }
        return -1;
    }

    private int GoingUp(Dictionary<int, List<Rider>> building)
    {
        for (int i = CurrentFloor + 1; i < _floorRange.Item2; i++)
        {
            if (building[i].Any(x => x.UpOrDown == Dir.Up) ||
                _destinationList.Any(x => x.Destination == i))
            {
                return i;
            }
        }
        CurrentDirection = Dir.Down;
        for (int i = _floorRange.Item2; i > _floorRange.Item1; i--)
        {
            if (building[i].Any(x => x.UpOrDown == Dir.Down) ||
                _destinationList.Any(x => x.Destination == i))
            {
                return i;
            }
        }
        CurrentDirection = Dir.Up;
        for (int i = _floorRange.Item1; i < _floorRange.Item2; i++)
        {
            if (building[i].Any(x => x.UpOrDown == Dir.Up) ||
                _destinationList.Any(x => x.Destination == i))
            {
                return i;
            }
        }
        return -1;
    }

    public void PassengerOn(Rider rider)
    {
        _destinationList.Add(rider);
        _currentCapacity = _destinationList.Count;
    }

    public void PassengerOff()
    {
        _destinationList = _destinationList.Where(x => x.Destination != CurrentFloor).ToList();
        _currentCapacity = _destinationList.Count;
        if (CurrentDirection == Dir.Down && CurrentFloor == _floorRange.Item1) CurrentDirection = Dir.Up;
        if (CurrentDirection == Dir.Up && CurrentFloor == _floorRange.Item2) CurrentDirection = Dir.Down;
    }

    public bool IsLiftFull()
    {
        return _currentCapacity == _maxCapacity;
    }

    public List<int> GetStopsList()
    {
        return _stopsList;
    }

    public void AddCurrentToStopList()
    {
        if (_stopsList.Count == 0 || _stopsList[_stopsList.Count - 1] != CurrentFloor) _stopsList.Add(CurrentFloor);
    }
}

public class Dinglemouse
{
    public static int[] TheLift(int[][] queues, int capacity)
    {
        var building = RidersDict(queues);
        var lift = new Lift(queues.Length - 1, capacity);

        int peopleOnFloor = building[0].Count;
        if (peopleOnFloor != 0)
        {
            for (int i = 0; i < peopleOnFloor; i++)
            {
                if (lift.IsLiftFull()) break;
                lift.PassengerOn(building[0][i]);
                building[lift.CurrentFloor].Remove(building[lift.CurrentFloor][i]);
                peopleOnFloor--;
                i--;
            }
        }

        lift.AddCurrentToStopList();
        int nextStop = 0;
        while (nextStop != -1)
        {
            nextStop = lift.NextStop(building);
            if (nextStop == -1) break;
            lift.CurrentFloor = nextStop;
            lift.AddCurrentToStopList();
            lift.PassengerOff();
            peopleOnFloor = building[lift.CurrentFloor].Count;
            for (int j = 0; j < peopleOnFloor; j++)
            {
                if (lift.IsLiftFull()) break;
                if (building[lift.CurrentFloor][j].UpOrDown == lift.CurrentDirection)
                {
                    lift.PassengerOn(building[lift.CurrentFloor][j]);
                    building[lift.CurrentFloor].Remove(building[lift.CurrentFloor][j]);
                    peopleOnFloor--;
                    j--;
                }
            }
        }

        if (lift.CurrentFloor == 0) return lift.GetStopsList().ToArray();
        lift.CurrentFloor = 0;
        lift.AddCurrentToStopList();
        return lift.GetStopsList().ToArray();
    }

    private static Dictionary<int, List<Rider>> RidersDict(int[][] queues)
    {
        var dict = new Dictionary<int, List<Rider>>();
        for (int i = 0; i < queues.Length; i++)
        {
            var list = new List<Rider>();
            for (int j = 0; j < queues[i].Length; j++)
            {
                var rd = new Rider(queues[i][j], i);
                list.Add(rd);
            }
            dict.Add(i, list);
        }

        return dict;
    }
}