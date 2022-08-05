double count = 0;
double time = 0;
double distance = 10000;
double first_person_speed = 1;
double second_person_speed = 2;
double dog_speed = 5;
double friend =2;


while(distance > 5)
{
    if(friend == 1)
    {
        time = distance / (first_person_speed + dog_speed);
        friend = 2;
    }
    
    if(friend == 2)
    {
        time = distance / (second_person_speed + dog_speed);
        friend = 1;
    }
    
    distance = distance - (first_person_speed + second_person_speed) * time;
    count = count + 1;
    Console.WriteLine(count);
}