﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csc03Aquarium
{
    internal class Aquarium
    {
        private const double MAX_SIDE = 100; // v cm
        private const double MIN_SIDE = 10; // v cm
        private const double MAX_VOLUME = 500000;
        private const double PRICE_GLUE = 1; // na 1cm
        private const double PRICE_CUT = 10; // na tabulku skla
        private const double PRICE_GLASS = 100; // na m2
        private const double DEFAULT_VAT = 1.21;

        protected double _width;
        protected double _height;
        protected double _length;

        public Aquarium(double width, double height, double length)
        {
            if (!VerifyValues(width, height, length))
            {
                throw new ArgumentException("Nesmyslná velikost akvárka.");
            }
            _width = width;
            _height = height;
            _length = length;
        }

        public static bool VerifyValues(double w, double l, double h)
        {
            if (w > MAX_SIDE || w < MIN_SIDE) return false;
            if (l > MAX_SIDE || l < MIN_SIDE) return false;
            if (h > MAX_SIDE || h < MIN_SIDE) return false;
            if (w * l * h > MAX_VOLUME) return false;
            return true;
        }

        public double Width 
        { 
            get { return _width; } 
            set 
            {
                if (!VerifyValues(value, Height, Length)) throw new ArgumentException("Nesmyslná šířka.");
                _width = value; 
            } 
        }
        public double Height
        {
            get { return _height; }
            set
            {
                if (!VerifyValues(Width, value, Length)) throw new ArgumentException("Nesmyslná délka.");
                _height = value;
            }
        }
        public double Length
        {
            get { return _length; }
            set
            {
                if (!VerifyValues(Width, Height, value)) throw new ArgumentException("Nesmyslná hloubka.");
                _length = value;
            }
        }

        public double GetVolume()
        {
            return Width * Height * Length;
        }

        public double Volume { get { return Width * Height * Length; } }

        public double Edges
        {
            get
            {
                return (4 * Height + 2 * Width + 2 * Length);
            }
        }

        public double Area
        {
            get
            {
                return ((Width * Length) + (Width * Height) * 2 + (Height * Length) * 2);
            }
        }

        public void Resize(double nw, double nh, double nl)
        {
            Width *= nw;
            Height *= nh;
            Length *= nl;
        }

        public void Resize(double nv)
        {
            //Width *= nv;
            //Height *= nv;
            //Length *= nv;
            Resize(nv,nv,nv);
        }

        public double Price()
        {
            return (
            5 * PRICE_CUT
            + PRICE_GLUE * Edges
            + PRICE_GLASS * Area / 100
            );      
        }

        public double PriceVAT(double vat = DEFAULT_VAT)
        {
            return Price() * vat;
        }
    }
}
