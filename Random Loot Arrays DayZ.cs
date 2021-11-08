        
Example of the Settings Random Loot Arrays for DayZ SMM    
/////////////////////////////////////////////////////        
        
        
        //Get random loadout             
        int selectedLoadout = Math.RandomIntInclusive(0,2);    // Num of loadouts
        
        //Spawn selected loadout items in mission object
        int j = 0;
        for (j = Math.RandomIntInclusive(1,4); j > 0; j--) MissionObject.GetInventory().CreateInInventory( Currency.GetRandomElement() ); //Between 1-4 Random Currency to be made in the seachest.
        for (j = Math.RandomIntInclusive(1,3); j > 0; j--) MissionObject.GetInventory().CreateInInventory( LootTableAmmo.GetRandomElement() );// Pull 1-3 Random Ammo Boxes.
        for (j = Math.RandomIntInclusive(1,3); j > 0; j--) MissionObject.GetInventory().CreateInInventory( LootTableFood.GetRandomElement() );// Pull 1-3 Random Food Items.
        for (j = Math.RandomIntInclusive(1,2); j > 0; j--) MissionObject.GetInventory().CreateInInventory( LootTableMeds.GetRandomElement() );// Pull 1-2 Random Medical Items.
        for (j = Math.RandomIntInclusive(1,1); j > 0; j--) MissionObject.GetInventory().CreateInInventory( LootTableWeaponParts.GetRandomElement() ); // Pull 1 Random Weapon Parts.


        if (selectedLoadout == 0) // If 1 Selected Make 1-3 of Items from Rare Items Table.
        {
            for (j = Math.RandomIntInclusive(1,3); j > 0; j--) MissionObject.GetInventory().CreateInInventory( LootTableRareItems.GetRandomElement() );
        }
        if (selectedLoadout == 1) // If 1 Selected Make 1-2 of Items from Weapons Table.
        {
            for (j = Math.RandomIntInclusive(1,2); j > 0; j--) MissionObject.GetInventory().CreateInInventory( LootTableWeapons.GetRandomElement() );
        }
        if (selectedLoadout == 2) // If 2 Selected Make 1-4 of Items from Basebuilding Table.
        {
            for (j = Math.RandomIntInclusive(1,4); j > 0; j--) MissionObject.GetInventory().CreateInInventory( LootTableBaseBuilding.GetRandomElement() ); 
        }



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //for (j = Math.RandomIntInclusive(0,0); j > 0; j--) MissionObject.GetInventory().CreateInInventory( Currency.GetRandomElement() );   //Between 0-0 Silver Bars to be made in the seachest.
        //for (j = Math.RandomIntInclusive(0,0); j > 0; j--) MissionObject.GetInventory().CreateInInventory( LootTableRareItems.GetRandomElement() );  // Pull 0-0 Random Items From TableItemsLarge.
        //for (j = Math.RandomIntInclusive(0,0); j > 0; j--) MissionObject.GetInventory().CreateInInventory( LootTableWeapons.GetRandomElement() );      // Pull 0-0 Random Weapons.
        //for (j = Math.RandomIntInclusive(0,0); j > 0; j--) MissionObject.GetInventory().CreateInInventory( LootTableWeaponParts.GetRandomElement() ); // Pull 0-0 Random Weapon Parts.
        //for (j = Math.RandomIntInclusive(0,0); j > 0; j--) MissionObject.GetInventory().CreateInInventory( LootTableAmmo.GetRandomElement() );         // Pull 0-0 Random Ammo Boxes.
        //for (j = Math.RandomIntInclusive(0,0); j > 0; j--) MissionObject.GetInventory().CreateInInventory( LootTableFood.GetRandomElement() );          // Pull 0-0 Random Food Items.
        //for (j = Math.RandomIntInclusive(0,0); j > 0; j--) MissionObject.GetInventory().CreateInInventory( LootTableMeds.GetRandomElement() );          // Pull 0-0 Random Medical Items.
        //for (j = Math.RandomIntInclusive(0,0); j > 0; j--) MissionObject.GetInventory().CreateInInventory( LootTableBaseBuilding.GetRandomElement() );  // Pull 0-0 Random Basebuilding Items.