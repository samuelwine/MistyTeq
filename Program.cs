await Bootstrapper
  .Factory
  .CreateWeb(args)
  #if !DEBUG
  .AddSetting("LinkRoot", "/MistyTeq")
  #endif
  .RunAsync();