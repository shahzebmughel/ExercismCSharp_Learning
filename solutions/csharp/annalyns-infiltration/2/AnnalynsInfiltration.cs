static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;

    }

    public static bool CanSpy(bool knwsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return knwsAwake || archerIsAwake || prisonerIsAwake;
        
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return !archerIsAwake && prisonerIsAwake;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        // if pet present | archer asleep | prisoner awake
        // or
        /* if dog not present prisoner and her msut be very sneaky.
            if dog not present, prisoner must be awake and knight && arhcher must be sleeping for it to work
        */
        
        return petDogIsPresent && !archerIsAwake ||
               (!petDogIsPresent && prisonerIsAwake) && !knightIsAwake && !archerIsAwake;
    }
}
