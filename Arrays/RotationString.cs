namespace problemsolving.Arrays
{
    public class RotationString
    {
        public bool IsRotation(string strLeft, string strRight){

            bool isRotation = false;

            var concatenatedString = strLeft + strRight;

            for (var i = 0; i < strLeft.Length; i++) {
                if (!concatenatedString.Contains(strRight)) continue;
                isRotation = true;
                break;
            }

            return isRotation;
        }
    }
}
