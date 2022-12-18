int count = 0, distance = 100, 
    speedFirstFriend = 1, speedSecondFriend = 2,
    speedDog = 5,
    friendDirection = 2;

while (distance>10){
    int time = 0;
    if (friendDirection == 1){
        time = distance / (speedFirstFriend + speedDog);
        friendDirection = 2;
    } else {
        time = distance / (speedSecondFriend + speedDog);
        friendDirection = 2;
    }
    distance = distance -(speedFirstFriend + speedSecondFriend) * time;
    count++;
}
Console.WriteLine(count);

