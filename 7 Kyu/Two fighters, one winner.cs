public class Kata {
  public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker) {
        Fighter SA = fighter1;
        Fighter FA = fighter2;
        if(fighter1.Name.Equals(firstAttacker))
        {
            SA = fighter2;
            FA = fighter1;
        }
        else
        {
            FA = fighter2;
            SA = fighter1;
        }
        do
        {
            SA.Health -= FA.DamagePerAttack;
            if(SA.Health <= 0)
            {return FA.Name;}
            FA.Health -= SA.DamagePerAttack;
            if(FA.Health <= 0)
            {return SA.Name;}
        }while(fighter1.Health > 0 && fighter2.Health > 0);
        return "Draw";
  }
}