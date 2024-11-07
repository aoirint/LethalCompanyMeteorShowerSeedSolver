bool CheckMeteorShowerChance(int seed, int time) {
  var meteorShowerChance = 7;
  var random = new Random(seed + 28);

  var isMeteorShower = random.Next(0, 1000) < meteorShowerChance;
  if (! isMeteorShower) {
    return false;
  }

  var meteorShowerAtTime = random.Next(5, 80);
  return meteorShowerAtTime == time;
}

int seedCount = 0;

while (true) {
  var seed = new Random().Next(1, 100000001);

  if (CheckMeteorShowerChance(seed, 5)) {
    Console.WriteLine(seed);

    seedCount += 1;
    if (seedCount >= 100) {
      break;
    }
  }
}
