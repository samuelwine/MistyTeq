await Bootstrapper
  .Factory
  .CreateWeb(args)
  .AddSetting("LinkRoot", "/MistyTeq")
  .RunAsync();