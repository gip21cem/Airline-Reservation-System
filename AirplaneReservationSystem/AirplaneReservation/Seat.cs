using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneReservation
{
    /* The [Serializable] attribute allows
     * any instance of the Seat class to be serialized;
     * in addition, by implementing the interface ISerializible,
     * the Seat class can customize the process of serialization
     */
    [Serializable] 
    public class Seat : ISerializable, IComparable //IComparable interface for default sort
    {
        private string seatNumber;
        private string classType;
        private string position;
        private string reservationStatus;
        private string passengerName;

        //constructor called for Seat object instantiation
        public Seat(string seatNumber, string classType, string position)
        {
            this.seatNumber = seatNumber;
            this.classType = classType;
            this.position = position;
        }

        public string SeatNumber
        {
            set { seatNumber = value; }
            get { return seatNumber; }
        }

        public string ClassType
        {
            set { classType = value; }
            get { return classType; }
        }

        public string Position
        {
            set { position = value; }
            get { return position; }
        }

        public string ReservationStatus
        {
            set { reservationStatus = value; }
            get { return reservationStatus; }
        }

        public string PassengerName
        {
            set { passengerName = value; }
            get { return passengerName; }
        }

        //override GetObjectData method from ISerializable for serialization 
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            //use AddValue to store values during object serialization
            info.AddValue("SeatNumber", SeatNumber);
            info.AddValue("ClassType", ClassType);
            info.AddValue("Position", Position);
            info.AddValue("ReservationStatus", ReservationStatus);
            info.AddValue("PassengerName", PassengerName);
        }

       //constructor called for de-serialization
        public Seat (SerializationInfo info, StreamingContext ctxt)
        {
            //use GetValue to retrieve values during object de-serialization
            SeatNumber = (string)info.GetValue("SeatNumber", typeof(string));
            ClassType = (string)info.GetValue("ClassType", typeof(string));
            Position = (string)info.GetValue("Position", typeof(string));
            ReservationStatus = (string)info.GetValue("ReservationStatus", typeof(string));
            PassengerName = (string)info.GetValue("PassengerName", typeof(string));
        }

        // implement CompareTo from IComparable
        // to provide default sort order for Seat objects
        // sort by passengerName
        public int CompareTo(object obj)
        {
            // guard condition
            if (obj is Seat)
            {
                Seat temp = (Seat)obj;
                // validate data
                if (this.PassengerName == null && temp.PassengerName == null)
                    return 0;
                else if (this.PassengerName == null)
                    return -1;
                else if (temp.PassengerName == null)
                    return 1;
                else 
                    return this.PassengerName.CompareTo(temp.PassengerName);
            }
            else
                throw new ArgumentException("Object is not a Seat"); 
        }

        // create a nested class that implements IComparer
        // for the alternative sort order, by seatNumber
        private class SortBySeatNumber : IComparer
        {
            public int Compare(object obj1, object obj2)
            {
                Seat temp1 = (Seat)obj1;
                Seat temp2 = (Seat)obj2;
                int le1 = temp1.seatNumber.Length;
                int le2 = temp2.seatNumber.Length;
                // if lengths of 2 strings is the same sort ascendigly
                if (le1 == le2)
                    return temp1.seatNumber.CompareTo(temp2.seatNumber);
                // if not, sort descendingly
                else 
                    return temp2.seatNumber.CompareTo(temp1.seatNumber); 
            }
        }

        // this method returns an instance of SortBySeatNumber
        // when called as argument of ArrayList.Sort
        public static IComparer sortBySeatNumber()
        {
            return (IComparer)new SortBySeatNumber();
        }
    }
}
