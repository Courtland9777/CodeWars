public class ProdFib {
      public static ulong[] productFib(ulong prod) {
      ulong prev = 0;
      ulong curr = 1;
      ulong multiplied = (ulong)prev * curr;

      while (multiplied < (ulong)prod)
      {
          ulong temp = curr;
          curr += prev;
          prev = temp;
          multiplied = prev * curr;
      }

      return new ulong[] { prev, curr, (ulong)(multiplied == (ulong)prod ? 1 : 0) };
      }
}