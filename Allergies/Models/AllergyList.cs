namespace Allergies.Models
{
  public class AllergyList
  {
    public int Score{get;set;}
    public AllergyList(int score)
    {
      Score = score;
    }
  }
}

/*
https://www.learnhowtoprogram.com/c-and-net/data-types-variables-branching-and-looping/dictionaries

need to set up an dictionary? with keys for allergies and values for score per each allergy
set up a method that takes allergy score and breaks down component allegeries that would add up to said score and returns a list of allergies
set up logic


run through this example: allergy(200)
output:


Dictionary allergyDict ->
Values - Keys
allergen     score
eggs         1
peanuts      2
shellfish    4
strawberries 8
tomatoes     16
chocolate    32
pollen       64
cats         128
extra allergy 256

allergy(200)
currentAllergy = 200; 


create an array of allergy values from largest to smallest
allergy array = [128,64,32,16,8,4,2,1]
another array = [cats, pollen, chocolate, tomatoes, strawberies, shellfish, peanuts, eggs]
if value at (i) <=  current allegy score then subtract value at index from current allergy score;
forEach(allergyarray) 
{
  if  currentAllergy >= allergyarray 
  current allergy - allergyarray
  make some note that we did this operation
  make a list push these values from another array
  [1,1,0,0,1,1,0,1]
}

return list

200 - 128 = 72 -> >= 0 so we add this to our allergies as an actual allergy
72 -64 = 8
8 - 32 = -24 -> !>= 0 so we skip
8 - 8 = 0
output = (cats, pollen, strawberries)
The plan



my idea

cats, pollen, chocolate, tomatoes, strawberies, shellfish, peanuts, eggs
 -> 1011 1010
1(index) * 2^n
*/