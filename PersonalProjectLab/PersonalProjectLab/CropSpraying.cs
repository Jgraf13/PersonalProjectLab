namespace PersonalProjectLab
{
    public class CropSpraying
    {
        public CropSpraying()
        {
        }

        public int CalculateCropDustingPrice(int rental, int acres, int pesticide)
        {
            //Crop dusting average = rental * acres * pesticide
            int price = 0;

            price = (rental * acres * pesticide);

            return price;
        }

        public int CalculateGroundSprayingPrice(int rental, int acres, int pesticides)
        {
            //Ground spraying average = rental * acres * peesticides
            int groundprice = 0;

            groundprice = (rental * acres * pesticides);

            return groundprice;

        }
    }
}
