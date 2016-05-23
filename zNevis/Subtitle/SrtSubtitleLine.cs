namespace zNevis
{
   public class SrtSubtitleLine
   {
      #region Properties
      public string Text { set; get; }
      public string Font { set; get; }
      public string Color { set; get; }
      public string ShowTime { set; get; }
      public string Duration { set; get; }
      public string HideTime { set; get; }
      public string Position1 { set; get; }
      public string Position2 { set; get; }
      #endregion

      public void Clear()
      {

      }

      public override string ToString()
      {
         return base.ToString();
      }
   }
}