using DataLogger.Models.Contracts;
using DataLogger.Models.Layouts;
using System;

namespace DataLogger.Factories
{
    public class LayoutFactory
    {
        public ILayout ProduceLayout(string type)
        {
            ILayout layout = null;

            if(type == "SimpleLayout")
            {
                layout = new SimpleLayout();
            }
            else if(type == "XmlLayout")
            {
                layout = new XmlLayout();
            }
            else
            {
                throw new ArgumentException("Invalid layout type!");
            }

            return layout;
        } 
    }
}
