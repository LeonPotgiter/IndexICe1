using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pilot
    {
        public int pilotID;
        public string pilotName, surname, flightName;
        public double travelDistance;

        public Pilot(int pilotID, string pilotName, string surname, string flightName, double travelDistance)
        {
            this.pilotID = pilotID;
            this.pilotName = pilotName;
            this.surname = surname;
            this.flightName = flightName;
            this.travelDistance = travelDistance;
        }

        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return this.pilotID;

                    case 1:
                        return this.pilotName;

                    case 2:
                        return this.surname;

                    case 3:
                        return this.flightName;

                    case 4:
                        return this.travelDistance;

                    default:
                        return null;
                }
            }

            set
            {
                switch (index)
                {
                    case 0:
                        this.pilotID = (int)value;
                        break;
                    case 1:
                        this.pilotName = (string)value;
                        break;
                    case 2:
                        this.surname = (string)value;
                        break;

                    case 3:
                        this.flightName = (string)value;
                        break;

                    case 4:
                        this.travelDistance = (double)value;
                        break;
                }
            }
        }
        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("pilotid"))
                {
                    return this.pilotID;
                }
                else if (attrName.ToLower().Equals("pilotname"))
                {
                    return this.pilotName;
                }
                else if (attrName.ToLower().Equals("surname"))
                {
                    return this.surname;
                }
                else if (attrName.ToLower().Equals("flightname"))
                {
                    return this.flightName;
                }
                else if (attrName.ToLower().Equals("traveldistance"))
                {
                    return this.travelDistance;
                }
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("pilotid"))
                {
                    this.pilotID = (int)value;
                }
                else if (attrName.ToLower().Equals("pilotname"))
                {
                    this.pilotName = (string)value;
                }
                else if (attrName.ToLower().Equals("surname"))
                {
                    this.surname = (string)value;
                }
                else if (attrName.ToLower().Equals("flightname"))
                {
                    this.flightName = (string)value;
                }
                else if (attrName.ToLower().Equals("traveldistance"))
                {
                    this.travelDistance = (double)value;
                }
            }
        }
    }


}
