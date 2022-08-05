int count = 0;
int time = 0;
int distance = 10000;
int first_person_speed = 1;
int second_person_speed = 2;
int dog_speed = 5;
int friend =2;


while(distance > 10)
{
    if(friend == 1)
    {
        time = distance / (first_person_speed + dog_speed);
        friend = 2;
        distance = distance - (first_person_speed + second_person_speed) * time;
    }
    
    if(friend == 2)
    {
        time = distance /(second_person_speed + dog_speed);
        friend = 1;
        distance = distance - (first_person_speed + second_person_speed) * time;
    }
    
    count = count + 1;
    Console.WriteLine(count);
}