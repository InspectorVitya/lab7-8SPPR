using System;
using System.Collections.Generic;
using System.IO;
using NetTopologySuite.Geometries;
using OSMLSGlobalLibrary;
using OSMLSGlobalLibrary.Map;
using OSMLSGlobalLibrary.Modules;
using PolylinerNet;
using JsonClass;
using System.Net;
using Newtonsoft.Json;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TestModule
{
    public class TestModule : OSMLSModule
    {

    

        
        long ellapledTicks = DateTime.Now.Ticks;
        //var tr = new List<Truck>() {
        //            new Truck(dataObj[i].Coordinate,1000,100,"Хендай Портер"),
        //            new Truck(dataObj[i].Coordinate,1500,95,"ГАЗель"),
        //            new Truck(dataObj[i].Coordinate,3000,60,"ЗИЛ Бычок"),
        //            new Truck(dataObj[i].Coordinate,20000,40,"Mercedesa Actros"),
        //        };



        protected override void Initialize()
        {
            var dataProvider = new Provider[]
            {
                new Provider (ConvertorCoordinates.DegressToMeter (new Coordinate (44.55142,48.75034))),
                new Provider (ConvertorCoordinates.DegressToMeter (new Coordinate (44.59463,48.78203))),
                new Provider (ConvertorCoordinates.DegressToMeter (new Coordinate (44.79315,48.79053))),
                new Provider (ConvertorCoordinates.DegressToMeter (new Coordinate (44.54144,48.72569))),
                new Provider (ConvertorCoordinates.DegressToMeter (new Coordinate (44.5254,48.5168))),
                new Provider (ConvertorCoordinates.DegressToMeter (new Coordinate (42.0385,45.0538))),
                new Provider (ConvertorCoordinates.DegressToMeter (new Coordinate (48.0301,46.3132))),
                new Provider (ConvertorCoordinates.DegressToMeter (new Coordinate (45.4435,50.1062))),
                new Provider (ConvertorCoordinates.DegressToMeter (new Coordinate (43.3556,47.7146))),
                new Provider (ConvertorCoordinates.DegressToMeter (new Coordinate (43.1807,47.6345))),
                new Provider (ConvertorCoordinates.DegressToMeter (new Coordinate (43.52569,47.51503))),
                new Provider (ConvertorCoordinates.DegressToMeter (new Coordinate (42.7437,47.4024))),
                new Provider (ConvertorCoordinates.DegressToMeter (new Coordinate (42.02164,47.54088))),
                new Provider (ConvertorCoordinates.DegressToMeter (new Coordinate (40.1786,47.7525))),
                new Provider (ConvertorCoordinates.DegressToMeter (new Coordinate (39.7137,47.2061))),
                new Provider (ConvertorCoordinates.DegressToMeter (new Coordinate (39.6152,47.1747))),
                new Provider (ConvertorCoordinates.DegressToMeter (new Coordinate (45.9464,51.4504))),
                new Provider (ConvertorCoordinates.DegressToMeter (new Coordinate (39.1443,51.6197))),

            };

            var dataCustomer = new Customer[]
            {
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 44.4363 ,48.6368))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 44.47366 ,48.77174))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 44.53234 ,48.76605))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 44.4913,48.7555))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 44.49195,48.7584))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 44.47033,48.72298))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 44.4848,48.7731))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 44.47683,48.80866))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 44.47119,48.82178))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 44.30677,48.83955))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 44.6329,48.9311))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 44.381,48.4392))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 44.11571,48.13854))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 43.63492,47.97267))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 43.16902,47.62197))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 43.163,47.6264))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 43.14769,47.63192))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 43.14185,47.62641))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 43.0996,47.6374))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 42.4064,47.1396))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 39.67889,47.26555))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 39.7664,47.2811))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 45.4278,50.1479))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 39.1911 ,51.6916))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 39.1503,51.6982))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 44.47876,48.72114))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 44.50368,48.73052))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 44.5972,48.7057))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 44.79771,48.77864))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 43.1416,47.6207))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate (37.658,55.6435))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate (35.969,56.837))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate (49.0265,55.8167))),
                new Customer (ConvertorCoordinates.DegressToMeter (new Coordinate ( 43.2668,47.6309)))
            };

            

            for (int i = 0; i< dataProvider.Length; i++)
            { 
                MapObjects.Add(dataProvider[i]);
            }

            for(int i = 0; i < dataCustomer.Length; i++)
            {
                MapObjects.Add(dataCustomer[i]);
            }

     


        }


        public override void Update(long elapsedMilliseconds)
        {
            // List<Truck> trucks = MapObjects.GetAll<Truck>();
            List<Provider> Providers = MapObjects.GetAll<Provider>();
            List<Customer> Customers = MapObjects.GetAll<Customer>();
            if (MapObjects.GetAll<Truck>().Count < 35 && Rand.MayBe(0.3))
            {

                MapObjects.Add(new Truck(new Coordinate(Providers[Rand.GenerateInRange(0, 17)].Coordinate), Rand.GenerateInRange(250, 5000), Rand.GenerateInRange(80, 120), new Coordinate(Customers[Rand.GenerateInRange(0, 32)].Coordinate)));

            }








            foreach (var truck in MapObjects.GetAll<Truck>())
            {
                

                if (!truck.InObj())
                {

                    truck.Move();
                }
                else if (truck.loaded)
                {
                   
                    
                    Console.WriteLine("Машина доехала до заказчика");
                    truck.loaded = false;
                    truck.goHome();
                }
                else if (truck.loaded )
                {
                    Console.WriteLine("Машина приехала с заказа");
                 
                    MapObjects.Remove(truck);
                }


            }



            //Console.WriteLine(MapObjects.GetAll<Truck>().Count);

        }



    }





    }

    static class ConvertorCoordinates
{
    // EPSG:3857 to EPSG:4326
    static public Coordinate MeterToDegress(Coordinate cord)
    {
        var lon = cord.X * 180 / 20037508.34;
        var lat = Math.Atan(Math.Exp(cord.Y * Math.PI / 20037508.34)) * 360 / Math.PI - 90;

        return new Coordinate(lon, lat);
        // should result in: -77.035974, 38.898717

    }
    // EPSG:4326 to EPSG:3857
    static public Coordinate DegressToMeter(Coordinate cord)
    {
        var x = cord.X * 20037508.34 / 180;
        var y = Math.Log(Math.Tan((90 + cord.Y) * Math.PI / 360)) / (Math.PI / 180);
        y = y * 20037508.34 / 180;
        return new Coordinate(Math.Round(x), Math.Round(y));


        // should result in: -8575605, 4707174e

    }
}


static class Navigator
{

    static public String GetRoad (Coordinate start, Coordinate end)
    {

        var str = "http://45.11.24.111:5000/route/v1/driving/"+ start.X.ToString().Replace(',','.')+','+start.Y.ToString().Replace(',', '.')+';'+ end.X.ToString().Replace(',', '.') + ',' + end.Y.ToString().Replace(',', '.');

        var httpWebRequest = (HttpWebRequest)WebRequest.Create(str);
        //43.1625,47.6281;43.1599,47.6252"

        httpWebRequest.ContentType = "text/json";
        httpWebRequest.Method = "GET";//Можно GET
        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
            //ответ от сервера
            var result = streamReader.ReadToEnd();

            //Сериализация
            RootObject res = JsonConvert.DeserializeObject<RootObject>(result);
            
            return res.routes[0].geometry;
        }



    }





    static public List<Coordinate> PolylineRoad(string polyline)
    {
        var polyliner = new Polyliner();
        var result = polyliner.Decode(polyline);

        List<Coordinate> test = new List<Coordinate>();
        for (int i = 0; i < result.Count; i++)
        {
            test.Add(ConvertorCoordinates.DegressToMeter(new Coordinate(result[i].Longitude, result[i].Latitude)));
        }

        return test;
    }



    public static double Distance( Coordinate p1, Coordinate p2) => Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));

}

[CustomStyle(
      @"new ol.style.Style({
        image: new ol.style.Circle({
            opacity: 1.0,
            scale: 1.0,
            radius: 4,
            fill: new ol.style.Fill({
                color: 'rgba(0, 255, 0, 1)'
            }),
            stroke: new ol.style.Stroke({
                color: 'rgba(0, 0, 0, 0.4)',
                width: 1
            }),
        })
    });
    ")]
class Provider : Point
{
    public Provider(Coordinate coordinate) : base(coordinate)
    {}


}
[CustomStyle(
      @"new ol.style.Style({
        image: new ol.style.Circle({
            opacity: 1.0,
            scale: 1.0,
            radius: 4,
            fill: new ol.style.Fill({
                color: 'rgba(0, 0, 255, 1)'
            }),
            stroke: new ol.style.Stroke({
                color: 'rgba(0, 0, 0, 0.4)',
                width: 1
            }),
        })
    });
    ")]
class Customer : Point
{

    public Customer(Coordinate coordinate) : base(coordinate)
    {
    }

}





[CustomStyle(
    @"new ol.style.Style({
    image: new ol.style.Circle({
        opacity: 1.0,
        scale: 1.0,
        radius: 3,
        fill: new ol.style.Fill({
            color: 'rgba(32, 250, 12, 1);'
        }),
        stroke: new ol.style.Stroke({
            color: 'rgba(0, 0, 0, 0.7)',
            width: 5
        }),
    })
});
")]
public class Truck : Point
{
    private int speed;
    public int weightGoods;
    public Coordinate home; 
    public Coordinate сustomer;
    public bool loaded = true;
    private List<Coordinate> deliveryPath;
    private List<Coordinate> homePath;
    public Truck(Coordinate coordinate, int weightGoods, int speed, Coordinate сustomer) : base(coordinate)
    {
     
        this.X += 10;
        this.Y += 10;
        this.speed = speed;
        this.weightGoods = weightGoods;
        this.home = new Coordinate(X, Y);
        this.сustomer = сustomer;
        this.deliveryPath = Navigator.PolylineRoad(Navigator.GetRoad(ConvertorCoordinates.MeterToDegress(coordinate), ConvertorCoordinates.MeterToDegress(сustomer)));
        this.homePath = new List<Coordinate> (deliveryPath);
        this.homePath.Reverse();

    }




    public void Move()
    {

        var x1 = X;
        var y1 = Y;
        var x = X;
        Double x2;
        Double y2;
        if (deliveryPath.Count - 1 != 0)
        {

            x2 = deliveryPath[0].X;
            y2 = deliveryPath[0].Y;

            if ((x1 == x2) && (y1 == y2))
            {
                x2 = deliveryPath[1].X;
                y2 = deliveryPath[1].Y;
                deliveryPath.RemoveAt(0);
            }

        }
        else if (loaded)
        { 
            x2 = сustomer.X;
            y2 = сustomer.Y;
        }
        else
        {
            x2 = home.X;
            y2 = home.Y;
        }
        
            if (x1 < x2)
            {
                x += speed;
                if ((x2 - x1) < speed)
                {
                    x += x2 - x1;
                }
            }
            if (x1 > x2)
            {
                x -= speed;
                if ((x1 - x2) < speed)
                {
                    x += x2 - x1;
                }
            }
  
            X = x;
            Y = ((y2 * (x - x1)) - (y1 * (x - x2))) / (x2 - x1);

        

    }

    public bool InObj()
    {
        if (loaded)
        {
            if (Navigator.Distance(new Coordinate(X, Y), сustomer) < 150)
            {
                return true;
            }
            else return false;

        }else
        {
            if (Navigator.Distance(new Coordinate(X, Y), home) < 150)
            {
                return true;
            }
            else return false;
        }
    }


    public void goHome()
    {
        deliveryPath = homePath;
    }

    }

static class Rand
{
    private static Random rand = new Random();

    public static int GenerateInRange(int min, int max) =>
        (int)Math.Round(min - 0.5 + rand.NextDouble() * (max - min + 1));

    public static Coordinate GenerateNext((int leftX, int rightX, int downY, int upY) map) =>
        new Coordinate(GenerateInRange(map.leftX, map.rightX), GenerateInRange(map.downY, map.upY));

    public static T RandomElement<T>(this ICollection<T> q)
    {
        return q.Skip(rand.Next(q.Count())).FirstOrDefault();
    }
    public static bool MayBe(double p = 0.5)
    {
        return rand.NextDouble() <= p;
    }
}