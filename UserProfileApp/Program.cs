using UserProfileApp;

Console.WriteLine("Hello, World!");

UserProfile profile = new UserProfile{
    Name = "Mari Kapanadze",
    Email = "mkapanadze2",
    age = 22
};

//idk what to do im just going to print all these >.<
if(!profile.IsValid()){
    Console.WriteLine("invalid user");
    return;
}

Console.WriteLine("profile details:");
Console.WriteLine($"Name: {profile.Name}");
Console.WriteLine($"Email: {profile.Email}");
Console.WriteLine($"Age: {profile.age}");