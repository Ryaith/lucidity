Updated and simplified version for web browsers playable here: https://ryaith.itch.io/lucidity-browser-version

For this submission, we have implemented the following:
• Boss aggro mechanics, allowing us to dynamically start and stop boss fights
• Interaction mechanics, allowing the user to interact with various objects.
	• This is an interface, so other objects can receive the interaction message and perform variable behaviour
• Inner Demons (in a basic form), which rotate and disappear when interacted with the 'e' key.
	• Each inner demon has an ID which will later be used to set flags in a static class, allowing us to know 
	which have been vanquished, and enabling future file saving
• "Endless Hallway," which moves the player back to the beginning of the trigger when exited while facing forwards
• "Turrets" spawining projectiles for bosses to fire. The projectiles in the demo only hurt when the player is moving.
• Damage and hitboxes, allowing the player to take (and heal) damage in boss fights
• The bridge puzzle, which uses the interaction system to dynamically spawn and hide bridge pieces

With these mechanics implemented, we can now progress on any puzzle we want to add to any level.
While the game may still use programmer art, we feel as though we have made significant enough progress on the project
to feel comfortable with the work we have left throughout the next term (and we'll certainly be ABLE to work more next term)
