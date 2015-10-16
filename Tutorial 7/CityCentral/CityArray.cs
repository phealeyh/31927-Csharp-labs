using System;
using System.IO;
using System.Windows.Forms;

namespace CityCentral
{
    public struct City
    {
        private string name;
        private double latitude;
        private double longitude;

        public string Name
        {
            get { return name; }
        }

        public double Latitude
        {
            get { return latitude; }
        }

        public double Longitude
        {
            get { return longitude; }
        }

        public City(string n, double lat, double lng)
        {
            name = n;
            latitude = lat;
            longitude = lng;
        }

        public double Distance(City other)
        {
            double latdif = latitude - other.latitude;
            double longdif = longitude - other.longitude;

            return Math.Sqrt(latdif * latdif + longdif * longdif);
        }

        public override string ToString()
        {
            StringWriter sw = new StringWriter();
            sw.Write("{0,-10} - {1, 6},{2, 6}", name, latitude, longitude);
            return sw.ToString();
        }
    }

    public class CityArray
    {
        private City[] cities;

        public CityArray(string cityFile)
        {
            LoadCities(cityFile);
        }

        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < cities.Length; i++)
            {
                s += (cities[i].ToString() + Environment.NewLine);
            }
            return s;
        }

        public int Length
        {
            get
            {
                if (cities == null) return 0;
                else return cities.Length;
            }
        }

        private void LoadCities(string cityFile)
        {
            cities = null;

            StreamReader fin;

            try
            {
                string line, name;
                int cityCount = 0;
                double lat, lng;

                // get count of cities;
                fin = new StreamReader(cityFile);
                while (!fin.EndOfStream)
                {
                    line = fin.ReadLine();
                    line.Trim();
                    if (line.Length > 0) cityCount++;
                }
                fin.Close();

                // create cities array
                cityCount /= 3;
                if (cityCount == 0) return;
                cities = new City[cityCount];

                // load cities into array
                fin = new StreamReader(cityFile);
                for (int i = 0; i < cityCount; i++)
                {
                    name = fin.ReadLine();
                    line = fin.ReadLine();
                    if (!double.TryParse(line, out lat)) break;
                    line = fin.ReadLine();
                    if (!double.TryParse(line, out lng)) break;
                    cities[i] = new City(name, lat, lng);
                }
                fin.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show("Unable to read city file with the following error\n" + e.Message, 
                    "City Central 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public City FindCentralCity()
        {
            double totLat = 0, totLong = 0;

            // work out average latitude and longitude. 
            // This will be the center of the cities
            for (int i = 0; i < cities.Length; i++)
            {
                totLat += cities[i].Latitude;
                totLong += cities[i].Longitude;
            }
            totLat /= cities.Length;
            totLong /= cities.Length;

            // create a new city located at center
            City central = new City("", totLat, totLong);

            // find city closest to center
            City closest = cities[0];
            double tempDist, minDist = central.Distance(closest);

            for (int i = 1; i < cities.Length; i++)
            {
                tempDist = central.Distance(cities[i]);
                if (tempDist < minDist)
                {
                    closest = cities[i];
                    minDist = tempDist;
                }
            }

            return closest;
        }
    } //end class

}
