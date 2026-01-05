using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Smart_Home_Control_Dashboard_HH;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
