# Path of Exile 2 AutoSplitter for LiveSplit

<img width="434" height="411" alt="image" src="https://github.com/user-attachments/assets/3b6b2b1a-cea5-4957-a9b0-410048026363" />

<img width="495" height="663" alt="image" src="https://github.com/user-attachments/assets/b6560423-8c31-4ef3-bbbd-0cf32572e164" />

## Installation
- Download and extract the repo.
- In PathOfExile2_AutoSplitterForLiveSplit-main > Component > DLL, find the LiveSplit.PathOfExile2AutoSplitter.dll file.
- Move it to your LiveSplit > Components folder.
- Open LiveSplit, right-click and select 'Edit Layout'.
- Click the + button, 'Timer' > 'Path of Exile 2'.
- Adjust the AutoSplitter settings by selecting 'Layout Settings' > 'Path of Exile 2'.

## Using the AutoSplitter
- The AutoSplitter comes with several Split modes: Campaign (100%), Campaign (Any%), and Level.
    - Campaign (100%) contains all areas in the Campaign, up to The Ziggurat Refuge.
    - Campaign (Any%) contains only mandatory Campaign areas, and Ascendancy areas.
    - Level will automatically split on reaching the next level.
 - With 'Enable Auto Splitting' checked, the AutoSplitter will Split when you enter the named campaign area for the first time. If you are splitting by levels, it will split when levelling up.
 - The order that you enter zones is important, as the splitter can't (yet) differentiate between what zone has entered and where the Split index is. If you are planning to run a different order to what is provided, edit your splits in the 'Edit Splits' menu before starting your run.
 - 'Enable New Character Auto Start' will automatically start the timer when you enter The Riverbank.

## Upcoming Features 

- Boss Dialogue split case for more accurate split times (Cemetery of the Eternals)
- Boss Rush setting for All and Mandatory Only bosses.
- Non-linear splitting to allow out-of-order progression.
- Test / implement compatibility with this save and quit component: https://github.com/Shotnex4/LiveSplit.TimeAttackPause
- Tool tips on layout settings.
- Load time removal (hopefully!)

## Known Issues and Limitations
- The AutoSplitter is reading from the Client.txt file, and currently does not account for load times. Splits occur when the campaign area begins loading.
- Cemetery of the Eternals split is inaccurate due to requirement to revisit multiple times and kill Lachlann. Needs 'Boss Dialogue' split event to get a more accurate split (split from The Grim Tangle on enter, add separate event for killing Lachlann). 
- Not sure how the two instances of The Halani Gates will behaves in Act 2.

### Thanks

This is my first LiveSplit component and I learned a lot from the following repos and tutorial
- https://github.com/brandondong/POE-LiveSplit-Component/tree/master
- https://github.com/Tazdraperm/Poe2AutoSplit
- https://gist.github.com/TheSoundDefense/cf85fd68ae582faa5f1cc95f18bba4ec
