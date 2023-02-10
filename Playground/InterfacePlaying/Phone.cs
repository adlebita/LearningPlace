namespace LearningPlace.InterfacePlaying;

public class Phone : IProduct
{
    public string Name { get; set; }
    public int Id { get; set; }
    private List<IProduct> Attachments = new List<IProduct>();

    public Phone()
    {
        /*
         * The below declaration qualifies in Typescript but not in c#. A concrete class that implements the interface
         * must be used.
         * 
         * var charger = new
         *   {
         *       Name: "Lightning",
         *       Id: 4
         *   };
         */
    }

}