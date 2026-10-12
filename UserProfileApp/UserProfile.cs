namespace UserProfileApp;
public class UserProfile{
    public string Name{get; set;} = string.Empty;
    public string Email{get; set;} = string.Empty;
    public int age {get; set;} 

    public bool IsValid(){
        return !String.IsNullOrWhiteSpace(Name) 
        && !String.IsNullOrWhiteSpace(Email)
        && age > 0;
    }
}