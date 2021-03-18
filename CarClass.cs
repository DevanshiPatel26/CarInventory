// Name: Devanshi Patel
// Student ID: 100805084
// Date: March 17, 2021
// Description: It is a class file.


using System;
using System.Collections.Generic;
using System.Text;

namespace CarInventory
{
    class CarClass
    {
        private static int carCount = 0;
        private int carIdentificationNumber = 0;
        private string carMake = String.Empty;
        private string carModel = String.Empty;
        private int carYear = 0;
        private decimal carPrice = 0;
        private bool carNewStatus = false;


        public CarClass()
        {
            carCount += 1;
            carIdentificationNumber = carCount;
        }


        public CarClass(string make, string model, int year, decimal price, bool newStatus): this()
        {
            //carIdentificationNumber = id;
            carMake = make;
            carModel = model;
            carYear = year;
            carPrice = price;
            carNewStatus = newStatus;
        }


        public int Count
        {
            get
            {
                return carCount;
            }
        }


        public int Id
        {
            get
            {
                return carIdentificationNumber;
            }
        }


        public bool NewStatus
        {
            get
            {
                return carNewStatus;
            }
            set
            {
                carNewStatus = value;
            }
        }


        public string Make
        {
            get
            {
                return carMake;
            }
            set
            {
                carMake = value;
            }
        }


        public string Model
        {
            get
            {
                return carModel;
            }
            set
            {
                carModel = value;
            }
        }


        public int Year
        {
            get
            {
                return carYear;
            }
            set
            {
                carYear = value;
            }
        }


        public decimal Price
        {
            get
            {
                return carPrice;
            }
            set
            {
                carPrice = value;
            }
        }


    }
}
