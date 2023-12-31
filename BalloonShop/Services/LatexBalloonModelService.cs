﻿using BalloonShop.Data;
using BalloonShop.Helpers;
using BalloonShop.Models.LatexBalloon;
using BalloonShop.Models.LatexBalloonType;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BalloonShop.Services;

public class LatexBalloonModelService
{
    public static void AddLatexBalloon(LatexBalloonModel latexBalloon, int lateBalloonTypeId)
    {
        if (latexBalloon != null)
        {
            using (var context = new ApplicationContext())
            {
                var balloonType = context.LatexBalloonTypes.Find(lateBalloonTypeId);

                if (balloonType != null)
                {
                    latexBalloon.LatexBalloonType = balloonType;
                    context.LatexBalloons.AddAsync(latexBalloon);
                    context.SaveChanges();
                }
            }
        }
    }

    public static decimal CalculateHeliumCost(int diameterOfTheBalloon, int countOfBalloonsInSetField, ref double sphereVolume)
    {
        var HeliumСubicMeterCost = (double)Constants.HeliumCanisterCost / 5.7;
        sphereVolume = Math.Round(((4 * Math.PI * Math.Pow(diameterOfTheBalloon/2, 3))/3000000), 3, MidpointRounding.ToPositiveInfinity);

        decimal cost = (decimal)(HeliumСubicMeterCost * sphereVolume * countOfBalloonsInSetField);
        return cost;
    }

    public static List<LatexBalloonModel> GetAllLatexBalloons()
    {
        using (var context = new ApplicationContext())
        {
            var latexBalloons = context.LatexBalloons.OrderBy(x => x.Name).ToList();

            foreach (var latexballoon in latexBalloons)
            {
                latexballoon.Image = ImageHelper.ConvertByteArrayToBitmapImage(latexballoon.ImageByteCode);
                latexballoon.PhotoImage = ImageHelper.ConvertByteArrayToBitmapImage(latexballoon.PhotoImageByteCode);
            }

            return latexBalloons;
        }
    }

    public static List<LatexBalloonModel> GetLatexBalloonsWithSpecificType(int lateBalloonTypeId)
    {
        using (var context = new ApplicationContext())
        {
            var dbLatexBalloonType = context.LatexBalloonTypes.Find(lateBalloonTypeId);

            var latexBalloons = context.LatexBalloons.Where(x => x.LatexBalloonType == dbLatexBalloonType).OrderBy(x => x.Name).ToList();

            foreach (var latexballoon in latexBalloons)
            {
                latexballoon.Image = ImageHelper.ConvertByteArrayToBitmapImage(latexballoon.ImageByteCode);
                latexballoon.PhotoImage = ImageHelper.ConvertByteArrayToBitmapImage(latexballoon.PhotoImageByteCode);
            }

            return latexBalloons;
        }
    }
}
