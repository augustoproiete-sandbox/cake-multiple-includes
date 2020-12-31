#load "a.cake"
#load "shared.cake"

Information("Hello from build.cake");

// This is ignored because it's included above
#load "a.cake"

// This is ignored because it's included above
#load "shared.cake"
