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
                            Name = "Лоб виска",
                        },
                        new Sector
                        {
                            Angl1 = 72, Angl2 = 85,
                            Name = "Глаз",
                        },
                        new Sector
                        {
                            Angl1 = 85, Angl2 = 100,
                            Name = "Нос, ухо",
                        },
                        new Sector
                        {
                            Angl1 = 100, Angl2 = 150,
                            Name = "Чулюсть, зубы",
                        },
                        new Sector
                        {
                            Angl1 = 150, Angl2 = 210,
                            Name = "Зона шеи, щитовидная железа",
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
                            Angl1 = 310, Angl2 = 60,
                            Name = "Поперечно ободочная кишка",
                        },
                        new Sector
                        {
                            Angl1 = 60, Angl2 = 80,
                            Name = "Шейный отдел",
                        },
                        new Sector
                        {
                            Angl1 = 80, Angl2 = 97,
                            Name = "Восходящая кишка",
                        },
                        new Sector
                        {
                            Angl1 = 280, Angl2 = 310,
                            Name = "Нисходящая кишка",
                        },
                        new Sector
                        {
                            Angl1 = 80, Angl2 = 97,
                            Name = "Грудной отдел",
                        },
                        new Sector
                        {
                            Angl1 = 210, Angl2 = 230,
                            Name = "Прямая кишка",
                        },
                        new Sector
                        {
                            Angl1 = 160, Angl2 = 170,
                            Name = "Поясничный отдел",
                        },
                        new Sector
                        {
                            Angl1 = 130, Angl2 = 160,
                            Name = "Аппендикс",
                        },
                        new Sector
                        {
                            Angl1 = 190, Angl2 = 210,
                            Name = "Крестец",
                        },
                        new Sector
                        {
                            Angl1 = 170, Angl2 = 190,
                            Name = "Копчик",
                        },
                        new Sector
                        {
                            Angl1 = 160, Angl2 = 170,
                            Name = "Слепая кишка",
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
                            Angl1 = 320, Angl2 = 45,
                            Name = "Зона головы",
                        },
                        new Sector
                        {
                            Angl1 = 270, Angl2 = 45,
                            Name = "Циркуляция крови",
                        },
                        new Sector
                        {
                            Angl1 = 45, Angl2 = 80,
                            Name = "Грудной отдел",
                        },
                        new Sector
                        {
                            Angl1 = 80, Angl2 = 110,
                            Name = "Лимфа",
                        },
                        new Sector
                        {
                            Angl1 = 210, Angl2 = 270,
                            Name = "Левая сторона груди, сердце",
                        },
                        new Sector
                        {
                            Angl1 = 110, Angl2 = 160,
                            Name = "Зона живота",
                        },
                        new Sector
                        {
                            Angl1 = 180, Angl2 = 210,
                            Name = "Почки",
                        },
                        new Sector
                        {
                            Angl1 = 160, Angl2 = 180,
                            Name = "Печень",
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
                            Angl1 = 360, Angl2 = 80,
                            Name = "Эпифиз",
                        },
                        new Sector
                        {
                            Angl1 = 310, Angl2 = 360,
                            Name = "Гипофиз",
                        },
                        new Sector
                        {
                            Angl1 = 280, Angl2 = 310,
                            Name = "Гипоталамус",
                        },
                        new Sector
                        {
                            Angl1 = 260, Angl2 = 280,
                            Name = "Нервная система",
                        },
                        new Sector
                        {
                            Angl1 = 80, Angl2 = 110,
                            Name = "Эндокринная система",
                        },
                        new Sector
                        {
                            Angl1 = 250, Angl2 = 260,
                            Name = "Селезенка",
                        },
                        new Sector
                        {
                            Angl1 = 110, Angl2 = 130,
                            Name = "Поджелудочная",
                        },
                        new Sector
                        {
                            Angl1 = 230, Angl2 = 250,
                            Name = "Надпочечник",
                        },
                        new Sector
                        {
                            Angl1 = 160, Angl2 = 230,
                            Name = "Уро-генитальная система",
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
                            Angl1 = 280, Angl2 = 45,
                            Name = "Коронарные сосуды",
                        },
                        new Sector
                        {
                            Angl1 = 45, Angl2 = 90,
                            Name = "Двенадцатиперстная кишка",
                        },
                        new Sector
                        {
                            Angl1 = 90, Angl2 = 120,
                            Name = "Тонкий кишечник",
                        },
                        new Sector
                        {
                            Angl1 = 210, Angl2 = 240,
                            Name = "Тощая кишка",
                        },
                        new Sector
                        {
                            Angl1 = 120, Angl2 = 210,
                            Name = "Респираторная система",
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
