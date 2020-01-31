namespace TwitterApi.Helper
{
    class Validation
    {
        public static bool RichTextControl(string text){
            int length = text.Length;
            if(length>0 && length < 280)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
