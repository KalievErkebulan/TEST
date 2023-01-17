Console.Clear();
float firstFriend = 1;
float secondFriend = 2;
float dogSpeed = 5;
float friend; 
float count = 0;
float Distance = 0;
float difSpeedFriend = secondFriend - firstFriend;
float currentCount;
while(Distance < 10)
{
Distance = Distance+difSpeedFriend;
currentCount = (dogSpeed/Distance);
Console.WriteLine(currentCount);
count = count+currentCount;
}
Console.WriteLine(count);
