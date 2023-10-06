using System;
using System.Diagnostics;

namespace BookLib
{
    public class Book
    {
        public int Id { get; set; }

        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                if (value.Length >= 3)
                {
                    _title = value;
                }
                else
                {
                    throw new ArgumentException("Titlen skal minimum have 3 bogstaver");
                }
            }
        }

        private double _price;

        public double Price
        {
            get { return _price; }
            set
            {
                if (value >= 0 && value <= 1200)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Prisen skal være mellem 0 og 1200 kr");
                }
            }
        }

        public Book(int id, string title, double price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public Book()
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Title)}={Title}, {nameof(Price)}={Price.ToString()}}}";
        }
    }
}