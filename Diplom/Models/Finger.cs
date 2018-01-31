using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Diplom.Models
{
    public class Finger
    {
        public string Name { get; set; }
        public List<Sector> Sectors { get; set; }

        public static List<Finger> LoadFingers(string path)
        {
            var json = File.ReadAllText(path);

            if (string.IsNullOrEmpty(json))
                throw new InvalidDataException();

            var res = JsonConvert.DeserializeObject<List<Finger>>(json);

            if (res.Count == 0)
                throw new InvalidDataException("No fingers data");

            return res;
        }

        public static void CreateTestData(string path)
        {
            List<Finger> data = new List<Finger>
            {
                #region Left hand
                new Finger
                {
                    Name = "Большой палец",
                    Sectors = new List<Sector>
                    {
                        new Sector
                        {
                            Angl1 = 300, Angl2 = 52,
                            Name = "Церебральнаяя зона",
                        },
                        new Sector
                        {
                            Angl1 = 52, Angl2 = 72,
                            Name = "Глаз",
                        },
                        new Sector
                        {
                            Angl1 = 72, Angl2 = 85,
                            Name = "Нос, ухо",
                        },
                        new Sector
                        {
                            Angl1 = 85, Angl2 = 100,
                            Name = "Зубы",
                        },
                        new Sector
                        {
                            Angl1 = 100, Angl2 = 240,
                            Name = "Зона горла, щитовидная железа",
                        },
                        

                    }
                },
                new Finger
                {
                    Name = "Указательный палец",
                    Sectors = new List<Sector>
                    {
                        new Sector
                        {
                            Angl1 = 0, Angl2 = 60,
                            Name = "Поперечно ободочная кишка",
                        },
                        new Sector
                        {
                            Angl1 = 60, Angl2 = 120,
                            Name = "Нисходящая кишка",
                        },
                        new Sector
                        {
                            Angl1 = 120, Angl2 = 150,
                            Name = "Сигмовидная кишка",
                        },
                        new Sector
                        {
                            Angl1 = 150, Angl2 = 180,
                            Name = "Прямая кишка",
                        },
                        new Sector
                        {
                            Angl1 = 180, Angl2 = 230,
                            Name = "Копчик крестец",
                        },
                        new Sector
                        {
                            Angl1 = 230, Angl2 = 265,
                            Name = "Поясничный отдел",
                        },
                        new Sector
                        {
                            Angl1 = 265, Angl2 = 310,
                            Name = "Грудной отдел",
                        },
                        new Sector
                        {
                            Angl1 = 310, Angl2 = 325,
                            Name = "Шейный отдел",
                        }
                        
                    }
                },
                new Finger
                {
                    Name = "Средний палец",
                    Sectors = new List<Sector>
                    {
                        new Sector
                        {
                            Angl1 = 335, Angl2 = 25,
                            Name = "Печень",
                        },
                        new Sector
                        {
                            Angl1 = 25, Angl2 = 30,
                            Name = "Грудь",
                        },
                        new Sector
                        {
                            Angl1 = 30, Angl2 = 70,
                            Name = "Живот",
                        },
                        new Sector
                        {
                            Angl1 = 70, Angl2 = 90,
                            Name = "Таз",
                        },
                        new Sector
                        {
                            Angl1 = 90, Angl2 = 140,
                            Name = "Ноги",
                        },
                        new Sector
                        {
                            Angl1 = 140, Angl2 = 158,
                            Name = "Стопа",
                        },
                        new Sector
                        {
                            Angl1 = 158, Angl2 = 205,
                            Name = "Почки",
                        },
                        new Sector
                        {
                            Angl1 = 205, Angl2 = 335,
                            Name = "Кровь",
                        },
                    }
                },
                new Finger
                {
                    Name = "Безымянный палец",
                    Sectors = new List<Sector>
                    {
                        new Sector
                        {
                            Angl1 = 350, Angl2 = 25,
                            Name = "Эпифиз",
                        },
                        new Sector
                        {
                            Angl1 = 25, Angl2 = 40,
                            Name = "Гипоталамус",
                        },
                        new Sector
                        {
                            Angl1 = 40, Angl2 = 155,
                            Name = "Нервная система",
                        },
                        new Sector
                        {
                            Angl1 = 155, Angl2 = 210,
                            Name = "Матка, простата",
                        },
                        new Sector
                        {
                            Angl1 = 210, Angl2 = 230,
                            Name = "Яичник",
                        },
                        new Sector
                        {
                            Angl1 = 230, Angl2 = 245,
                            Name = "Надпочечник",
                        },
                        new Sector
                        {
                            Angl1 = 245, Angl2 = 255,
                            Name = "П/жел железа",
                        },
                        new Sector
                        {
                            Angl1 = 255, Angl2 = 280,
                            Name = "Вилочковая железа",
                        },
                        new Sector
                        {
                            Angl1 = 280, Angl2 = 315,
                            Name = "Паращитовидная железа",
                        },
                        new Sector
                        {
                            Angl1 = 315, Angl2 = 350,
                            Name = "Паращитовидная железа",
                        },
                    }
                },
                new Finger
                {
                    Name = "Мизинец",
                    Sectors = new List<Sector>
                    {
                        new Sector
                        {
                            Angl1 = 0, Angl2 = 90,
                            Name = "Сосуды сердца, левое предсердие",
                        },
                        new Sector
                        {
                            Angl1 = 90, Angl2 = 150,
                            Name = "Левый желудочек, коронарные сосуды",
                        },
                        new Sector
                        {
                            Angl1 = 150, Angl2 = 210,
                            Name = "Бронхи, Легкие, молочные железы",
                        },
                        new Sector
                        {
                            Angl1 = 210, Angl2 = 308,
                            Name = "Подвздошная кишка",
                        },
                        new Sector
                        {
                            Angl1 = 308, Angl2 = 0,
                            Name = "Valva ileocaccalis",
                        },
                    }
                },
                
                #endregion Left hand
                
                #region Right hand
              
                #endregion Right hand 
            };

            string json = JsonConvert.SerializeObject(data.ToArray());

            //write string to file
            File.WriteAllText(path, json);

        }
    }
}
