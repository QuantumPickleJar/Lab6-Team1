﻿using Microsoft.Extensions.Logging;
using Lab6_Starter.Model;

namespace Lab6_Starter;

public static class MauiProgram
{
	
    public static IBusinessLogic BusinessLogic = new BusinessLogic(new Database());

    public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

