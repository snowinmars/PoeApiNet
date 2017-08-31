using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PoeApiNet.Entities;

namespace PoeApiNet.Core
{
	public class StashApi
	{
		#region cosnt

		private const string json = @"{
    ""next_change_id"": ""2524-4356-3991-4730-1300"",
    ""stashes"": [
        {
            ""accountName"": ""Nightlines"",
            ""lastCharacterName"": ""ProbablyStuff"",
            ""id"": ""f1496c6c7bf8a26f4100e130d162155efff900e3e63648e54e08bdde6efe69f2"",
            ""stash"": ""LEVELING UNIQUES"",
            ""stashType"": ""PremiumStash"",
            ""items"": [
                
            ],
            ""public"": false
        },
        {
            ""accountName"": ""Jephire"",
            ""lastCharacterName"": """",
            ""id"": ""b55b3d1ddb0ab4f0a4f0f38211f779082c3493aef8e09459c9886cd525b4cf48"",
            ""stash"": ""$"",
            ""stashType"": ""PremiumStash"",
            ""items"": [
                
            ],
            ""public"": false
        },
        {
            ""accountName"": ""5a4oK"",
            ""lastCharacterName"": ""temniypoputchik_mad"",
            ""id"": ""e929b40875df8f853e392e4f56656983ba2b2eaad1121fc7b1f58d7111a3d958"",
            ""stash"": ""Orbs"",
            ""stashType"": ""PremiumStash"",
            ""items"": [
                
            ],
            ""public"": false
        },
        {
            ""accountName"": ""5a4oK"",
            ""lastCharacterName"": ""temniypoputchik_mad"",
            ""id"": ""a4e30c88ab255322f3fd8372a6d815d431a4ace4a0236732ba4e63461d272795"",
            ""stash"": ""What i need"",
            ""stashType"": ""PremiumStash"",
            ""items"": [
                {
                    ""verified"": false,
                    ""w"": 2,
                    ""h"": 4,
                    ""ilvl"": 71,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Weapons\/TwoHandWeapons\/Bows\/SarkhamsReach.png?scale=1&scaleIndex=0&w=2&h=4&v=f333c2e4005ee20a84270731baa5fa6a3"",
                    ""league"": ""Hardcore"",
                    ""id"": ""176b5e6f7af0a5bb4b48d7fdafa47501a179f4ea095815a58c82c4b5244b3cdb"",
                    ""sockets"": [
                        {
                            ""group"": 0,
                            ""attr"": ""D""
                        }
                    ],
                    ""name"": ""<<set:MS>><<set:M>><<set:S>>\u041f\u0440\u0435\u0434\u0435\u043b \u0420\u043e\u0442\u0430"",
                    ""typeLine"": ""\u0417\u0430\u0433\u043d\u0443\u0442\u044b\u0439 \u043b\u0443\u043a"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""note"": ""~price 10 exa"",
                    ""properties"": [
                        {
                            ""name"": ""\u041b\u0443\u043a"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041a\u0430\u0447\u0435\u0441\u0442\u0432\u043e"",
                            ""values"": [
                                [
                                    ""+17%"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 6
                        },
                        {
                            ""name"": ""\u0424\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u0438\u0439 \u0443\u0440\u043e\u043d"",
                            ""values"": [
                                [
                                    ""20-63"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 9
                        },
                        {
                            ""name"": ""\u0428\u0430\u043d\u0441 \u043a\u0440\u0438\u0442\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0434\u0430\u0440\u0430"",
                            ""values"": [
                                [
                                    ""6.50%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 12
                        },
                        {
                            ""name"": ""\u0410\u0442\u0430\u043a \u0432 \u0441\u0435\u043a\u0443\u043d\u0434\u0443"",
                            ""values"": [
                                [
                                    ""1.31"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 13
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""18"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041b\u043e\u0432\u043a"",
                            ""values"": [
                                [
                                    ""65"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""explicitMods"": [
                        ""68% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0444\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430"",
                        ""5% \u043f\u043e\u0432\u044b\u0448\u0435\u043d\u0438\u0435 \u0441\u043a\u043e\u0440\u043e\u0441\u0442\u0438 \u0430\u0442\u0430\u043a\u0438"",
                        ""\u0423\u043c\u0435\u043d\u0438\u044f \u043f\u043e\u0440\u0430\u0436\u0430\u044e\u0442 \u0446\u0435\u043b\u0435\u0439 \u043f\u043e \u0446\u0435\u043f\u0438: +1"",
                        ""30% \u043f\u043e\u0432\u044b\u0448\u0435\u043d\u0438\u0435 \u0441\u043a\u043e\u0440\u043e\u0441\u0442\u0438 \u0441\u043d\u0430\u0440\u044f\u0434\u043e\u0432"",
                        ""34% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u0441\u0442\u0438\u0445\u0438\u0439 \u043e\u0442 \u0443\u043c\u0435\u043d\u0438\u0439 \u0430\u0442\u0430\u043a""
                    ],
                    ""flavourText"": [
                        ""\u00ab\u0418\u0437\u0433\u043d\u0430\u043d \u0432 \u043c\u043e\u0440\u0435, \u0432\u043e\u0442 \u043f\u043e\u0442\u0435\u0445\u0430!\r"",
                        ""\u041c\u043d\u0435 \u0437\u0434\u0435\u0441\u044c \u0432\u043e\u043b\u044c\u0433\u043e\u0442\u043d\u0435\u0439, \u0447\u0435\u043c \u043d\u0430 \u0441\u0443\u0448\u0435\u00bb.\r"",
                        ""- \u043a\u0430\u043f\u0438\u0442\u0430\u043d \u00ab\u0427\u0451\u0440\u043d\u043e\u0433\u043e \u0433\u0440\u0435\u0431\u043d\u044f\u00bb \u0412\u0435\u0439\u043b\u0430\u043c \u00ab\u0413\u043d\u0438\u043b\u043e\u0437\u0443\u0431\u00bb \u0420\u043e\u0442""
                    ],
                    ""frameType"": 3,
                    ""x"": 10,
                    ""y"": 0,
                    ""inventoryId"": ""Stash1"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 0,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/LeapSlam.png?scale=1&scaleIndex=0&w=1&h=1&v=73d0b5f9f1c52f0e0e87f74a80a549ab3"",
                    ""support"": false,
                    ""league"": ""Hardcore"",
                    ""id"": ""8d84024bd2f99bd467b671e6915bc999f6e26f512c7f7034f54ff182781198e6"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""\u041d\u0430\u0441\u043a\u043e\u043a"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0410\u0442\u0430\u043a\u0430, \u041e\u0431\u043b\u0430\u0441\u0442\u044c, \u0414\u0432\u0438\u0436\u0435\u043d\u0438\u0435, \u0411\u043b\u0438\u0436\u043d\u0438\u0439 \u0431\u043e\u0439"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""1"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 5
                        },
                        {
                            ""name"": ""\u0420\u0430\u0441\u0445\u043e\u0434 \u043c\u0430\u043d\u044b"",
                            ""values"": [
                                [
                                    ""15"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""additionalProperties"": [
                        {
                            ""name"": ""\u041e\u043f\u044b\u0442"",
                            ""values"": [
                                [
                                    ""9569\/9569"",
                                    0
                                ]
                            ],
                            ""displayMode"": 2,
                            ""progress"": 1
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""10"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0421\u0438\u043b\u0430"",
                            ""values"": [
                                [
                                    ""29"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""nextLevelRequirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""13"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0421\u0438\u043b\u0430"",
                            ""values"": [
                                [
                                    ""35"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""secDescrText"": ""\u0413\u0435\u0440\u043e\u0439 \u043f\u0440\u044b\u0433\u0430\u0435\u0442 \u0432 \u0443\u043a\u0430\u0437\u0430\u043d\u043d\u043e\u0435 \u043c\u0435\u0441\u0442\u043e \u0438 \u0440\u0430\u043d\u0438\u0442 \u0432\u0440\u0430\u0433\u043e\u0432 \u0441\u0432\u043e\u0438\u043c \u043e\u0441\u043d\u043e\u0432\u043d\u044b\u043c \u043e\u0440\u0443\u0436\u0438\u0435\u043c (\u043d\u0435\u043a\u043e\u0442\u043e\u0440\u044b\u0445 \u043c\u043e\u0436\u0435\u0442 \u043e\u0442\u0431\u0440\u043e\u0441\u0438\u0442\u044c). \u041d\u0430\u0432\u044b\u043a \u0442\u0440\u0435\u0431\u0443\u0435\u0442 \u0442\u043e\u043f\u043e\u0440, \u0431\u0443\u043b\u0430\u0432\u0443, \u043c\u0435\u0447 \u0438\u043b\u0438 \u043f\u043e\u0441\u043e\u0445. \u041d\u0435\u043b\u044c\u0437\u044f \u0443\u0441\u0438\u043b\u0438\u0442\u044c \u0413\u0440\u0430\u0434\u043e\u043c \u0443\u0434\u0430\u0440\u043e\u0432."",
                    ""explicitMods"": [
                        ""20% \u0448\u0430\u043d\u0441 \u043e\u0442\u0431\u0440\u043e\u0441\u0438\u0442\u044c \u0432\u0440\u0430\u0433\u043e\u0432 \u043f\u0440\u0438 \u043d\u0430\u043d\u0435\u0441\u0435\u043d\u0438\u0438 \u0443\u0434\u0430\u0440\u0430""
                    ],
                    ""descrText"": ""\u0414\u043b\u044f \u043f\u043e\u043b\u0443\u0447\u0435\u043d\u0438\u044f \u0443\u043c\u0435\u043d\u0438\u044f \u0432\u044b\u0431\u0435\u0440\u0438\u0442\u0435 \u043f\u0440\u0435\u0434\u043c\u0435\u0442 \u0438 \u043f\u043e\u043c\u0435\u0441\u0442\u0438\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u0432 \u0433\u043d\u0435\u0437\u0434\u043e \u0441\u043e\u043e\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0443\u044e\u0449\u0435\u0433\u043e \u0446\u0432\u0435\u0442\u0430. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                    ""frameType"": 4,
                    ""x"": 0,
                    ""y"": 1,
                    ""inventoryId"": ""Stash2"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 1,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Jewels\/HighQuestRewardRed.png?scale=1&scaleIndex=0&w=1&h=1&v=fcfea32513c2b1566a61fddfd1c341c93"",
                    ""league"": ""Hardcore"",
                    ""id"": ""d9503c22d6a753bed25ee06b63e8b17ad5f898cc7266a6eccebe6f993ee8944f"",
                    ""sockets"": [
                        
                    ],
                    ""name"": ""<<set:MS>><<set:M>><<set:S>>\u0421\u043c\u0435\u043a\u0430\u043b\u043a\u0430 \u043f\u043e\u0431\u0435\u0434\u0438\u0442\u0435\u043b\u044f"",
                    ""typeLine"": ""\u0411\u0430\u0433\u0440\u043e\u0432\u044b\u0439 \u0441\u0430\u043c\u043e\u0446\u0432\u0435\u0442"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u041c\u0430\u043a\u0441\u0438\u043c\u0443\u043c"",
                            ""values"": [
                                [
                                    ""1"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""explicitMods"": [
                        ""3% \u0441\u043d\u0438\u0436\u0435\u043d\u0438\u0435 \u0437\u0430\u0442\u0440\u0430\u0442 \u043c\u0430\u043d\u044b \u0443\u043c\u0435\u043d\u0438\u0439"",
                        ""4% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0434\u043b\u0438\u0442\u0435\u043b\u044c\u043d\u043e\u0441\u0442\u0438 \u044d\u0444\u0444\u0435\u043a\u0442\u0430 \u0443\u043c\u0435\u043d\u0438\u044f"",
                        ""2% \u0443\u043c\u0435\u043d\u044c\u0448\u0435\u043d\u0438\u0435 \u043e\u0431\u044a\u0435\u043c\u0430 \u0443\u0434\u0435\u0440\u0436\u0430\u043d\u043d\u043e\u0439 \u043c\u0430\u043d\u044b""
                    ],
                    ""descrText"": ""\u041f\u043e\u043c\u0435\u0441\u0442\u0438\u0442\u0435 \u0441\u0430\u043c\u043e\u0446\u0432\u0435\u0442 \u0432 \u0434\u043e\u0441\u0442\u0443\u043f\u043d\u043e\u0435 \u0433\u043d\u0435\u0437\u0434\u043e \u043d\u0430 \u0434\u0435\u0440\u0435\u0432\u0435 \u043f\u0430\u0441\u0441\u0438\u0432\u043d\u044b\u0445 \u0443\u043c\u0435\u043d\u0438\u0439. \u0427\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u0441\u0430\u043c\u043e\u0446\u0432\u0435\u0442, \u0449\u0451\u043b\u043a\u043d\u0438\u0442\u0435 \u043f\u043e \u043d\u0435\u043c\u0443 \u043f\u0440\u0430\u0432\u043e\u0439 \u043a\u043d\u043e\u043f\u043a\u043e\u0439 \u043c\u044b\u0448\u0438."",
                    ""flavourText"": [
                        ""\u0418 \u043a\u0430\u043c\u0435\u043d\u044c \u043c\u043e\u0436\u0435\u0442 \u0438\u0441\u0442\u0435\u0447\u044c \u043a\u0440\u043e\u0432\u044c\u044e.""
                    ],
                    ""frameType"": 3,
                    ""x"": 11,
                    ""y"": 5,
                    ""inventoryId"": ""Stash3"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 73,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Amulets\/TurquoiseAmulet.png?scale=1&scaleIndex=0&w=1&h=1&v=484a8eac4316c65308deea4efcfbb6213"",
                    ""league"": ""Hardcore"",
                    ""id"": ""358da932979a1121115fd923e0d57fd9fb7f179ddca77a7abfe6e1d767034924"",
                    ""sockets"": [
                        
                    ],
                    ""name"": ""<<set:FP>><<set:F>><<set:P>><if:MS>{\u0414\u0443\u0448\u0435\u0432\u043d\u044b\u0439
                    }<elif:FS>{\u0414\u0443\u0448\u0435\u0432\u043d\u0430\u044f
                    }<elif:NS>{\u0414\u0443\u0448\u0435\u0432\u043d\u043e\u0435
                    }<elif:MP>{\u0414\u0443\u0448\u0435\u0432\u043d\u044b\u0435
                    }<elif:FP>{\u0414\u0443\u0448\u0435\u0432\u043d\u044b\u0435
                    }<elif:NP>{\u0414\u0443\u0448\u0435\u0432\u043d\u044b\u0435
                    } \u0431\u0443\u0441\u044b"",
                    ""typeLine"": ""\u0410\u043c\u0443\u043b\u0435\u0442 \u0441 \u0431\u0438\u0440\u044e\u0437\u043e\u0439"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""57"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""implicitMods"": [
                        ""+18 \u043a \u043b\u043e\u0432\u043a\u043e\u0441\u0442\u0438 \u0438 \u0438\u043d\u0442\u0435\u043b\u043b\u0435\u043a\u0442\u0443""
                    ],
                    ""explicitMods"": [
                        ""11% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u0447\u0430\u0440"",
                        ""\u0414\u043e\u0431\u0430\u0432\u043b\u044f\u0435\u0442 \u043e\u0442 18 \u0434\u043e 31 \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u043e\u0433\u043d\u044f \u043a \u0430\u0442\u0430\u043a\u0430\u043c"",
                        ""37% \u043f\u043e\u0432\u044b\u0448\u0435\u043d\u0438\u0435 \u0433\u043b\u043e\u0431\u0430\u043b\u044c\u043d\u043e\u0433\u043e \u0448\u0430\u043d\u0441\u0430 \u043a\u0440\u0438\u0442\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0434\u0430\u0440\u0430"",
                        ""+25 \u043a \u043c\u0430\u043a\u0441\u0438\u043c\u0443\u043c\u0443 \u043c\u0430\u043d\u044b"",
                        ""+27% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u043e\u0433\u043d\u044e"",
                        ""+23% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u0445\u043e\u043b\u043e\u0434\u0443""
                    ],
                    ""frameType"": 2,
                    ""x"": 0,
                    ""y"": 0,
                    ""inventoryId"": ""Stash4"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 0,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/Support\/IncreasedDuration.png?scale=1&scaleIndex=0&w=1&h=1&v=14b3a91933f0b921d1b573358e31f7683"",
                    ""support"": true,
                    ""league"": ""Hardcore"",
                    ""id"": ""2ce90c7a129f83de3406769e8b9e09763be5e5ad4311bf475cf5d4375831f705"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""\u041f\u0440\u043e\u0434\u043b\u0435\u043d\u0438\u0435"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u041f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0430, \u0414\u043b\u0438\u0442\u0441\u044f"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""1"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 5
                        },
                        {
                            ""name"": ""\u041c\u043d\u043e\u0436\u0438\u0442\u0435\u043b\u044c \u043c\u0430\u043d\u044b"",
                            ""values"": [
                                [
                                    ""140%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""additionalProperties"": [
                        {
                            ""name"": ""\u041e\u043f\u044b\u0442"",
                            ""values"": [
                                [
                                    ""1\/285815"",
                                    0
                                ]
                            ],
                            ""displayMode"": 2,
                            ""progress"": 3.4987667731911642e-6
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""31"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0421\u0438\u043b\u0430"",
                            ""values"": [
                                [
                                    ""52"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""secDescrText"": ""\u0423\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u0442 \u043b\u044e\u0431\u043e\u0435 \u0443\u043c\u0435\u043d\u0438\u0435 \u0441 \u0432\u0440\u0435\u043c\u0435\u043d\u0435\u043c \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044f."",
                    ""explicitMods"": [
                        ""\u0423\u0441\u0438\u043b\u0435\u043d\u043d\u044b\u0435 \u0443\u043c\u0435\u043d\u0438\u044f \u0438\u043c\u0435\u044e\u0442 45% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0434\u043b\u0438\u0442\u0435\u043b\u044c\u043d\u043e\u0441\u0442\u0438 \u044d\u0444\u0444\u0435\u043a\u0442\u043e\u0432 \u0443\u043c\u0435\u043d\u0438\u0439""
                    ],
                    ""descrText"": ""\u042d\u0442\u043e \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438. \u041e\u043d \u0434\u0430\u0435\u0442 \u043f\u0440\u0435\u0438\u043c\u0443\u0449\u0435\u0441\u0442\u0432\u0430 \u043d\u0435 \u0433\u0435\u0440\u043e\u044e, \u0430 \u043a\u0430\u043c\u043d\u044e \u0443\u043c\u0435\u043d\u0438\u044f \u0432 \u0441\u0432\u044f\u0437\u0430\u043d\u043d\u044b\u0445 \u0433\u043d\u0435\u0437\u0434\u0430\u0445. \u0412\u0441\u0442\u0430\u0432\u044c\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438 \u0432 \u0433\u043d\u0435\u0437\u0434\u043e, \u0441\u043e\u0435\u0434\u0438\u043d\u0435\u043d\u043d\u043e\u0435 \u0441 \u0433\u043d\u0435\u0437\u0434\u043e\u043c \u0443\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u043c\u043e\u0433\u043e \u043a\u0430\u043c\u043d\u044f \u0430\u043a\u0442\u0438\u0432\u043d\u043e\u0433\u043e \u0443\u043c\u0435\u043d\u0438\u044f. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                    ""frameType"": 4,
                    ""x"": 0,
                    ""y"": 2,
                    ""inventoryId"": ""Stash5"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 2,
                    ""ilvl"": 71,
                    ""icon"": ""https:\/\/web.poecdn.com\/gen\/image\/YTo1OntzOjEwOiJsZWFn\/dWVOYW1lIjtzOjg6Ikhh\/cmRjb3JlIjtzOjk6ImFj\/Y291bnRJZCI7TzoxODoi\/R3JpbmRiXERhdGFiYXNl\/XElkIjoxOntzOjI6Imlk\/IjtpOjA7fWk6MjthOjM6\/e3M6MToiZiI7czozMzoi\/QXJ0LzJESXRlbXMvRmxh\/c2tzL2V2YXNpb25mbGFz\/azAxIjtzOjI6InNwIjtk\/OjAuNjA4NTE5MjY5Nzc2\/ODc2MztzOjU6ImxldmVs\/IjtpOjA7fWk6MTtpOjQ7\/aTowO2k6OTt9\/962406f429\/Item.png"",
                    ""league"": ""Hardcore"",
                    ""id"": ""bcd6e8fa61888422a1faed414577030569395da4290012e1bbe54b017071011b"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""\u041d\u0435\u0444\u0440\u0438\u0442\u043e\u0432\u044b\u0439 \u0444\u043b\u0430\u043a\u043e\u043d"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0414\u043b\u0438\u0442\u0441\u044f %0 \u0441\u0435\u043a."",
                            ""values"": [
                                [
                                    ""4.00"",
                                    0
                                ]
                            ],
                            ""displayMode"": 3
                        },
                        {
                            ""name"": ""\u0420\u0430\u0441\u0445\u043e\u0434\u0443\u0435\u0442 %0 \u0438\u0437 %1 \u0437\u0430\u0440\u044f\u0434\u043e\u0432 \u043f\u0440\u0438 \u0438\u0441\u043f\u043e\u043b\u044c\u0437\u043e\u0432\u0430\u043d\u0438\u0438"",
                            ""values"": [
                                [
                                    ""30"",
                                    0
                                ],
                                [
                                    ""60"",
                                    0
                                ]
                            ],
                            ""displayMode"": 3
                        },
                        {
                            ""name"": ""\u0421\u043e\u0434\u0435\u0440\u0436\u0438\u0442 \u0437\u0430\u0440\u044f\u0434\u043e\u0432: %0"",
                            ""values"": [
                                [
                                    ""0"",
                                    0
                                ]
                            ],
                            ""displayMode"": 3
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""27"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""utilityMods"": [
                        ""+3000 \u043a \u0443\u043a\u043b\u043e\u043d\u0435\u043d\u0438\u044e""
                    ],
                    ""descrText"": ""\u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043f\u0438\u0442\u044c. \u0421\u043e\u0434\u0435\u0440\u0436\u0438\u0442 \u0437\u0430\u0440\u044f\u0434\u044b \u0442\u043e\u043b\u044c\u043a\u043e \u043a\u043e\u0433\u0434\u0430 \u0432\u0438\u0441\u0438\u0442 \u043d\u0430 \u043f\u043e\u044f\u0441\u0435. \u041f\u043e\u043f\u043e\u043b\u043d\u044f\u0435\u0442\u0441\u044f \u043f\u043e \u043c\u0435\u0440\u0435 \u0443\u0431\u0438\u0439\u0441\u0442\u0432\u0430 \u043c\u043e\u043d\u0441\u0442\u0440\u043e\u0432."",
                    ""frameType"": 0,
                    ""x"": 10,
                    ""y"": 8,
                    ""inventoryId"": ""Stash6"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 2,
                    ""ilvl"": 62,
                    ""icon"": ""https:\/\/web.poecdn.com\/gen\/image\/YTo1OntzOjEwOiJsZWFn\/dWVOYW1lIjtzOjg6Ikhh\/cmRjb3JlIjtzOjk6ImFj\/Y291bnRJZCI7TzoxODoi\/R3JpbmRiXERhdGFiYXNl\/XElkIjoxOntzOjI6Imlk\/IjtpOjA7fWk6MjthOjM6\/e3M6MToiZiI7czozMDoi\/QXJ0LzJESXRlbXMvRmxh\/c2tzL2xpZmVmbGFzazEw\/IjtzOjI6InNwIjtkOjAu\/NjA4NTE5MjY5Nzc2ODc2\/MztzOjU6ImxldmVsIjtp\/OjA7fWk6MTtpOjQ7aTow\/O2k6OTt9\/a24528c4a8\/Item.png"",
                    ""league"": ""Hardcore"",
                    ""id"": ""5e968f419af74b6c673927fd0f083ab3599573d2879d1f6e9c27085a761ea9fa"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""<<set:MS>><<set:M>><<set:S>><if:MS>{\u041e\u0441\u0442\u043e\u0440\u043e\u0436\u043d\u044b\u0439
                    }<elif:FS>{\u041e\u0441\u0442\u043e\u0440\u043e\u0436\u043d\u0430\u044f
                    }<elif:NS>{\u041e\u0441\u0442\u043e\u0440\u043e\u0436\u043d\u043e\u0435
                    }<elif:MP>{\u041e\u0441\u0442\u043e\u0440\u043e\u0436\u043d\u044b\u0435
                    }<elif:FP>{\u041e\u0441\u0442\u043e\u0440\u043e\u0436\u043d\u044b\u0435
                    }<elif:NP>{\u041e\u0441\u0442\u043e\u0440\u043e\u0436\u043d\u044b\u0435
                    } \u0411\u043e\u0436\u0435\u0441\u0442\u0432\u0435\u043d\u043d\u044b\u0439 \u0444\u043b\u0430\u043a\u043e\u043d \u0436\u0438\u0437\u043d\u0438 \u043e\u0431\u0435\u0440\u0435\u0433\u0430"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u041a\u0430\u0447\u0435\u0441\u0442\u0432\u043e"",
                            ""values"": [
                                [
                                    ""+20%"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 6
                        },
                        {
                            ""name"": ""\u0412\u043e\u0441\u0441\u0442\u0430\u043d\u0430\u0432\u043b\u0438\u0432\u0430\u0435\u0442 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u0435: %0 \u0437\u0430 %1 \u0441\u0435\u043a."",
                            ""values"": [
                                [
                                    ""2880"",
                                    1
                                ],
                                [
                                    ""7.00"",
                                    0
                                ]
                            ],
                            ""displayMode"": 3
                        },
                        {
                            ""name"": ""\u0420\u0430\u0441\u0445\u043e\u0434\u0443\u0435\u0442 %0 \u0438\u0437 %1 \u0437\u0430\u0440\u044f\u0434\u043e\u0432 \u043f\u0440\u0438 \u0438\u0441\u043f\u043e\u043b\u044c\u0437\u043e\u0432\u0430\u043d\u0438\u0438"",
                            ""values"": [
                                [
                                    ""15"",
                                    0
                                ],
                                [
                                    ""45"",
                                    0
                                ]
                            ],
                            ""displayMode"": 3
                        },
                        {
                            ""name"": ""\u0421\u043e\u0434\u0435\u0440\u0436\u0438\u0442 \u0437\u0430\u0440\u044f\u0434\u043e\u0432: %0"",
                            ""values"": [
                                [
                                    ""0"",
                                    0
                                ]
                            ],
                            ""displayMode"": 3
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""60"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""explicitMods"": [
                        ""100% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0432\u043e\u0441\u0441\u0442\u0430\u043d\u043e\u0432\u043b\u0435\u043d\u0438\u044f \u043f\u0440\u0438 \u043c\u0430\u043b\u043e\u043c \u043a\u043e\u043b\u0438\u0447\u0435\u0441\u0442\u0432\u0435 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f"",
                        ""\u0418\u043c\u043c\u0443\u043d\u0438\u0442\u0435\u0442 \u043a \u043f\u0440\u043e\u043a\u043b\u044f\u0442\u0438\u044f\u043c \u0432\u043e \u0432\u0440\u0435\u043c\u044f \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044f \u044d\u0444\u0444\u0435\u043a\u0442\u0430 \u0444\u043b\u0430\u043a\u043e\u043d\u0430\n\u041f\u0440\u0438 \u0438\u0441\u043f\u043e\u043b\u044c\u0437\u043e\u0432\u0430\u043d\u0438\u0438 \u0441\u043d\u0438\u043c\u0430\u0435\u0442 \u043f\u0440\u043e\u043a\u043b\u044f\u0442\u0438\u044f""
                    ],
                    ""descrText"": ""\u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043f\u0438\u0442\u044c. \u0421\u043e\u0434\u0435\u0440\u0436\u0438\u0442 \u0437\u0430\u0440\u044f\u0434\u044b \u0442\u043e\u043b\u044c\u043a\u043e \u043a\u043e\u0433\u0434\u0430 \u0432\u0438\u0441\u0438\u0442 \u043d\u0430 \u043f\u043e\u044f\u0441\u0435. \u041f\u043e\u043f\u043e\u043b\u043d\u044f\u0435\u0442\u0441\u044f \u043f\u043e \u043c\u0435\u0440\u0435 \u0443\u0431\u0438\u0439\u0441\u0442\u0432\u0430 \u043c\u043e\u043d\u0441\u0442\u0440\u043e\u0432."",
                    ""frameType"": 1,
                    ""x"": 11,
                    ""y"": 6,
                    ""inventoryId"": ""Stash7"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 72,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Amulets\/TurquoiseAmulet.png?scale=1&scaleIndex=0&w=1&h=1&v=484a8eac4316c65308deea4efcfbb6213"",
                    ""league"": ""Hardcore"",
                    ""id"": ""ec668472eadc44c1cbca519d5f1b085cc68adda7aaa1440511d6724b699d3506"",
                    ""sockets"": [
                        
                    ],
                    ""name"": ""<<set:FP>><<set:F>><<set:P>><if:MS>{\u0414\u044c\u044f\u0432\u043e\u043b\u044c\u0441\u043a\u0438\u0439
                    }<elif:FS>{\u0414\u044c\u044f\u0432\u043e\u043b\u044c\u0441\u043a\u0430\u044f
                    }<elif:NS>{\u0414\u044c\u044f\u0432\u043e\u043b\u044c\u0441\u043a\u043e\u0435
                    }<elif:MP>{\u0414\u044c\u044f\u0432\u043e\u043b\u044c\u0441\u043a\u0438\u0435
                    }<elif:FP>{\u0414\u044c\u044f\u0432\u043e\u043b\u044c\u0441\u043a\u0438\u0435
                    }<elif:NP>{\u0414\u044c\u044f\u0432\u043e\u043b\u044c\u0441\u043a\u0438\u0435
                    } \u0431\u0443\u0441\u044b"",
                    ""typeLine"": ""\u0410\u043c\u0443\u043b\u0435\u0442 \u0441 \u0431\u0438\u0440\u044e\u0437\u043e\u0439"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""57"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""implicitMods"": [
                        ""+18 \u043a \u043b\u043e\u0432\u043a\u043e\u0441\u0442\u0438 \u0438 \u0438\u043d\u0442\u0435\u043b\u043b\u0435\u043a\u0442\u0443""
                    ],
                    ""explicitMods"": [
                        ""20% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u0447\u0430\u0440"",
                        ""+11 \u043a\u043e \u0432\u0441\u0435\u043c \u0445\u0430\u0440\u0430\u043a\u0442\u0435\u0440\u0438\u0441\u0442\u0438\u043a\u0430\u043c"",
                        ""+32 \u043a \u043c\u0430\u043a\u0441\u0438\u043c\u0443\u043c\u0443 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f"",
                        ""+43% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u0445\u043e\u043b\u043e\u0434\u0443""
                    ],
                    ""frameType"": 2,
                    ""x"": 0,
                    ""y"": 7,
                    ""inventoryId"": ""Stash8"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 0,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/ImmortalCall.png?scale=1&scaleIndex=0&w=1&h=1&v=3843ced383e5dca18e076e57e9f678193"",
                    ""support"": false,
                    ""league"": ""Hardcore"",
                    ""id"": ""c4a85d530351912d143119656fb542bf9408457f2329bb8dfeb32a00f49866bf"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""\u041f\u0440\u0438\u0437\u044b\u0432 \u043a \u0431\u0435\u0441\u0441\u043c\u0435\u0440\u0442\u0438\u044e"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0427\u0430\u0440\u044b, \u0414\u043b\u0438\u0442\u0441\u044f"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""1"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 5
                        },
                        {
                            ""name"": ""\u0420\u0430\u0441\u0445\u043e\u0434 \u043c\u0430\u043d\u044b"",
                            ""values"": [
                                [
                                    ""21"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041f\u0435\u0440\u0435\u0437\u0430\u0440\u044f\u0434\u043a\u0430"",
                            ""values"": [
                                [
                                    ""3.00 \u0441\u0435\u043a."",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0412\u0440\u0435\u043c\u044f \u043f\u0440\u0438\u043c\u0435\u043d\u0435\u043d\u0438\u044f"",
                            ""values"": [
                                [
                                    ""0.85 \u0441\u0435\u043a."",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""additionalProperties"": [
                        {
                            ""name"": ""\u041e\u043f\u044b\u0442"",
                            ""values"": [
                                [
                                    ""1\/252595"",
                                    0
                                ]
                            ],
                            ""displayMode"": 2,
                            ""progress"": 3.9589067455381155e-6
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""34"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0421\u0438\u043b\u0430"",
                            ""values"": [
                                [
                                    ""79"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""secDescrText"": ""\u0413\u0435\u0440\u043e\u0439 \u043b\u0438\u0448\u0430\u0435\u0442\u0441\u044f \u0432\u0441\u0435\u0445 \u043d\u0430\u043a\u043e\u043f\u043b\u0435\u043d\u043d\u044b\u0445 \u0437\u0430\u0440\u044f\u0434\u043e\u0432 \u0432\u044b\u043d\u043e\u0441\u043b\u0438\u0432\u043e\u0441\u0442\u0438 \u0438 \u043d\u0435\u043d\u0430\u0434\u043e\u043b\u0433\u043e \u0441\u0442\u0430\u043d\u043e\u0432\u0438\u0442\u0441\u044f \u043d\u0435\u0443\u044f\u0437\u0432\u0438\u043c\u044b\u043c \u043a \u0444\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u043e\u043c\u0443 \u0443\u0440\u043e\u043d\u0443. \u0414\u043b\u0438\u0442\u0435\u043b\u044c\u043d\u043e\u0441\u0442\u044c \u0437\u0430\u0449\u0438\u0442\u044b \u0437\u0430\u0432\u0438\u0441\u0438\u0442 \u043e\u0442 \u043a\u043e\u043b\u0438\u0447\u0435\u0441\u0442\u0432\u0430 \u043f\u043e\u0442\u0440\u0430\u0447\u0435\u043d\u043d\u044b\u0445 \u0437\u0430\u0440\u044f\u0434\u043e\u0432."",
                    ""explicitMods"": [
                        ""\u0411\u0430\u0437\u043e\u0432\u0430\u044f \u0434\u043b\u0438\u0442\u0435\u043b\u044c\u043d\u043e\u0441\u0442\u044c: 0.40 \u0441\u0435\u043a\u0443\u043d\u0434"",
                        ""100% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0434\u043b\u0438\u0442\u0435\u043b\u044c\u043d\u043e\u0441\u0442\u0438 \u043f\u043e\u043b\u043e\u0436\u0438\u0442\u0435\u043b\u044c\u043d\u043e\u0433\u043e \u044d\u0444\u0444\u0435\u043a\u0442\u0430 \u0437\u0430 \u0437\u0430\u0440\u044f\u0434 \u0432\u044b\u043d\u043e\u0441\u043b\u0438\u0432\u043e\u0441\u0442\u0438""
                    ],
                    ""descrText"": ""\u0414\u043b\u044f \u043f\u043e\u043b\u0443\u0447\u0435\u043d\u0438\u044f \u0443\u043c\u0435\u043d\u0438\u044f \u0432\u044b\u0431\u0435\u0440\u0438\u0442\u0435 \u043f\u0440\u0435\u0434\u043c\u0435\u0442 \u0438 \u043f\u043e\u043c\u0435\u0441\u0442\u0438\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u0432 \u0433\u043d\u0435\u0437\u0434\u043e \u0441\u043e\u043e\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0443\u044e\u0449\u0435\u0433\u043e \u0446\u0432\u0435\u0442\u0430. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                    ""frameType"": 4,
                    ""x"": 0,
                    ""y"": 6,
                    ""inventoryId"": ""Stash9"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 0,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/HeraldofIce.png?scale=1&scaleIndex=0&w=1&h=1&v=098e32bf010edc365f1ec453f3477bc73"",
                    ""support"": false,
                    ""league"": ""Hardcore"",
                    ""id"": ""3431d653f0728e1c58db7a2f1cfee5191b5534bb8883b752e487e1cd4949a9a7"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""\u0412\u0435\u0441\u0442\u043d\u0438\u043a \u043b\u044c\u0434\u0430"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0421\u043e\u0442\u0432\u043e\u0440\u0435\u043d\u0438\u0435, \u041e\u0431\u043b\u0430\u0441\u0442\u044c, \u0425\u043e\u043b\u043e\u0434, \u0412\u0435\u0441\u0442\u043d\u0438\u043a"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""1"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 5
                        },
                        {
                            ""name"": ""\u0423\u0434\u0435\u0440\u0436\u0430\u043d\u043e \u043c\u0430\u043d\u044b"",
                            ""values"": [
                                [
                                    ""25%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041f\u0435\u0440\u0435\u0437\u0430\u0440\u044f\u0434\u043a\u0430"",
                            ""values"": [
                                [
                                    ""1.00 \u0441\u0435\u043a."",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0412\u0440\u0435\u043c\u044f \u043f\u0440\u0438\u043c\u0435\u043d\u0435\u043d\u0438\u044f"",
                            ""values"": [
                                [
                                    ""1.00 \u0441\u0435\u043a."",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u042d\u0444\u0444\u0435\u043a\u0442\u0438\u0432\u043d\u043e\u0441\u0442\u044c \u0434\u043e\u0431\u0430\u0432\u043b\u0435\u043d\u043d\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430"",
                            ""values"": [
                                [
                                    ""80%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""additionalProperties"": [
                        {
                            ""name"": ""\u041e\u043f\u044b\u0442"",
                            ""values"": [
                                [
                                    ""1\/49725"",
                                    0
                                ]
                            ],
                            ""displayMode"": 2,
                            ""progress"": 2.011060860240832e-5
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""16"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041b\u043e\u0432\u043a"",
                            ""values"": [
                                [
                                    ""26"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        },
                        {
                            ""name"": ""\u0418\u043d\u0442"",
                            ""values"": [
                                [
                                    ""18"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""secDescrText"": ""\u0413\u0435\u0440\u043e\u0439 \u043d\u0430\u043f\u043e\u043b\u043d\u044f\u0435\u0442 \u0440\u0443\u043a\u0438 \u0445\u043e\u043b\u043e\u0434\u043e\u043c \u043b\u044c\u0434\u0430, \u043d\u0430\u043d\u043e\u0441\u044f \u0434\u043e\u043f\u043e\u043b\u043d\u0438\u0442\u0435\u043b\u044c\u043d\u044b\u0439 \u0443\u0440\u043e\u043d \u043e\u0442 \u0445\u043e\u043b\u043e\u0434\u0430 \u0443\u0434\u0430\u0440\u0430\u043c\u0438 \u0438 \u0447\u0430\u0440\u0430\u043c\u0438. \u0415\u0441\u043b\u0438 \u0432\u043e \u0432\u0440\u0435\u043c\u044f \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044f \u043d\u0430\u0432\u044b\u043a\u0430 \u0433\u0435\u0440\u043e\u0439 \u0440\u0430\u0441\u043a\u0430\u043b\u044b\u0432\u0430\u0435\u0442 \u0432\u0440\u0430\u0433\u0430, \u0442\u043e\u0442 \u0432\u0437\u0440\u044b\u0432\u0430\u0435\u0442\u0441\u044f \u0438 \u0440\u0430\u043d\u0438\u0442 \u0434\u0440\u0443\u0433\u0438\u0445 \u043e\u043a\u0430\u0437\u0430\u0432\u0448\u0438\u0445\u0441\u044f \u043f\u043e\u0431\u043b\u0438\u0437\u043e\u0441\u0442\u0438 \u0432\u0440\u0430\u0433\u043e\u0432."",
                    ""explicitMods"": [
                        ""\u041d\u0430\u043d\u043e\u0441\u0438\u0442 \u043e\u0442 18 \u0434\u043e 26 \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u0445\u043e\u043b\u043e\u0434\u0430"",
                        ""\u0423\u0440\u043e\u043d \u043d\u0435 \u043c\u043e\u0436\u0435\u0442 \u0431\u044b\u0442\u044c \u043e\u0442\u0440\u0430\u0436\u0451\u043d"",
                        ""\u0414\u043e\u0431\u0430\u0432\u043b\u044f\u0435\u0442 \u043e\u0442 4 \u0434\u043e 5 \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u0445\u043e\u043b\u043e\u0434\u0430 \u043a \u0430\u0442\u0430\u043a\u0430\u043c"",
                        ""\u0414\u043e\u0431\u0430\u0432\u043b\u044f\u0435\u0442 \u043e\u0442 4 \u0434\u043e 5 \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u0445\u043e\u043b\u043e\u0434\u0430 \u043a \u0447\u0430\u0440\u0430\u043c""
                    ],
                    ""descrText"": ""\u0414\u043b\u044f \u043f\u043e\u043b\u0443\u0447\u0435\u043d\u0438\u044f \u0443\u043c\u0435\u043d\u0438\u044f \u0432\u044b\u0431\u0435\u0440\u0438\u0442\u0435 \u043f\u0440\u0435\u0434\u043c\u0435\u0442 \u0438 \u043f\u043e\u043c\u0435\u0441\u0442\u0438\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u0432 \u0433\u043d\u0435\u0437\u0434\u043e \u0441\u043e\u043e\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0443\u044e\u0449\u0435\u0433\u043e \u0446\u0432\u0435\u0442\u0430. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                    ""frameType"": 4,
                    ""x"": 0,
                    ""y"": 5,
                    ""inventoryId"": ""Stash10"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 1,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Jewels\/MidQuestRewardRed.png?scale=1&scaleIndex=0&w=1&h=1&v=aa8cbeb565cc7d9ea0c852f2889ab9d23"",
                    ""league"": ""Hardcore"",
                    ""id"": ""e768eb8f423f0ffc5cbf2e1e687f3e9f4289ff48565f2876b4a03033c3047c90"",
                    ""sockets"": [
                        
                    ],
                    ""name"": ""<<set:MS>><<set:M>><<set:S>>\u0414\u043b\u0438\u043d\u043d\u044b\u0435 \u0440\u0443\u043a\u0438"",
                    ""typeLine"": ""\u0411\u0430\u0433\u0440\u043e\u0432\u044b\u0439 \u0441\u0430\u043c\u043e\u0446\u0432\u0435\u0442"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u041c\u0430\u043a\u0441\u0438\u043c\u0443\u043c"",
                            ""values"": [
                                [
                                    ""1"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""explicitMods"": [
                        ""8% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u0430\u0442\u0430\u043a"",
                        ""+1 \u043a \u0434\u0430\u043b\u044c\u043d\u043e\u0441\u0442\u0438 \u0430\u0442\u0430\u043a\u0438 \u043e\u0440\u0443\u0436\u0438\u0435\u043c \u0431\u043b\u0438\u0436\u043d\u0435\u0433\u043e \u0431\u043e\u044f \u0438\u043b\u0438 \u0431\u0435\u0437 \u043e\u0440\u0443\u0436\u0438\u044f""
                    ],
                    ""descrText"": ""\u041f\u043e\u043c\u0435\u0441\u0442\u0438\u0442\u0435 \u0441\u0430\u043c\u043e\u0446\u0432\u0435\u0442 \u0432 \u0434\u043e\u0441\u0442\u0443\u043f\u043d\u043e\u0435 \u0433\u043d\u0435\u0437\u0434\u043e \u043d\u0430 \u0434\u0435\u0440\u0435\u0432\u0435 \u043f\u0430\u0441\u0441\u0438\u0432\u043d\u044b\u0445 \u0443\u043c\u0435\u043d\u0438\u0439. \u0427\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u0441\u0430\u043c\u043e\u0446\u0432\u0435\u0442, \u0449\u0451\u043b\u043a\u043d\u0438\u0442\u0435 \u043f\u043e \u043d\u0435\u043c\u0443 \u043f\u0440\u0430\u0432\u043e\u0439 \u043a\u043d\u043e\u043f\u043a\u043e\u0439 \u043c\u044b\u0448\u0438."",
                    ""flavourText"": [
                        ""\u041a\u0440\u0435\u043f\u043a\u0430\u044f \u0440\u0443\u043a\u0430 \u0438 \u0432\u043e\u0439\u0441\u043a\u043e \u043e\u0441\u0442\u0430\u043d\u043e\u0432\u0438\u0442.""
                    ],
                    ""frameType"": 3,
                    ""x"": 11,
                    ""y"": 4,
                    ""inventoryId"": ""Stash11"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 0,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/Support\/LifeLeech.png?scale=1&scaleIndex=0&w=1&h=1&v=a286b7cb68bee2319a14a80c1e4bcf9c3"",
                    ""support"": true,
                    ""league"": ""Hardcore"",
                    ""id"": ""27134d26d7bd46362435339f2be02f76b21ac4018cc72e6c5e9e4c83436df071"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""\u0412\u044b\u0442\u044f\u0433\u0438\u0432\u0430\u043d\u0438\u0435 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u041f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0430"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""1"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 5
                        },
                        {
                            ""name"": ""\u041c\u043d\u043e\u0436\u0438\u0442\u0435\u043b\u044c \u043c\u0430\u043d\u044b"",
                            ""values"": [
                                [
                                    ""130%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""additionalProperties"": [
                        {
                            ""name"": ""\u041e\u043f\u044b\u0442"",
                            ""values"": [
                                [
                                    ""1\/285815"",
                                    0
                                ]
                            ],
                            ""displayMode"": 2,
                            ""progress"": 3.4987667731911642e-6
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""31"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0421\u0438\u043b\u0430"",
                            ""values"": [
                                [
                                    ""52"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""secDescrText"": ""\u0423\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u0442 \u043b\u044e\u0431\u043e\u0435 \u0443\u043c\u0435\u043d\u0438\u0435, \u043d\u0430\u043d\u043e\u0441\u044f\u0449\u0435\u0435 \u0443\u0434\u0430\u0440\u044b \u043f\u043e \u0432\u0440\u0430\u0433\u0430\u043c. \u0423\u0441\u0438\u043b\u0435\u043d\u043d\u043e\u0435 \u0443\u043c\u0435\u043d\u0438\u0435 \u043f\u043e\u0445\u0438\u0449\u0430\u0435\u0442 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u0435 \u043d\u0430 \u043e\u0441\u043d\u043e\u0432\u0430\u043d\u0438\u0438 \u043d\u0430\u043d\u0435\u0441\u0435\u043d\u043d\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430."",
                    ""explicitMods"": [
                        ""2% \u043e\u0442 \u0443\u0440\u043e\u043d\u0430 \u0443\u0441\u0438\u043b\u0435\u043d\u043d\u044b\u0445 \u0443\u043c\u0435\u043d\u0438\u0439 \u043f\u043e\u0445\u0438\u0449\u0430\u0435\u0442\u0441\u044f \u0432 \u0432\u0438\u0434\u0435 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f""
                    ],
                    ""descrText"": ""\u042d\u0442\u043e \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438. \u041e\u043d \u0434\u0430\u0435\u0442 \u043f\u0440\u0435\u0438\u043c\u0443\u0449\u0435\u0441\u0442\u0432\u0430 \u043d\u0435 \u0433\u0435\u0440\u043e\u044e, \u0430 \u043a\u0430\u043c\u043d\u044e \u0443\u043c\u0435\u043d\u0438\u044f \u0432 \u0441\u0432\u044f\u0437\u0430\u043d\u043d\u044b\u0445 \u0433\u043d\u0435\u0437\u0434\u0430\u0445. \u0412\u0441\u0442\u0430\u0432\u044c\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438 \u0432 \u0433\u043d\u0435\u0437\u0434\u043e, \u0441\u043e\u0435\u0434\u0438\u043d\u0435\u043d\u043d\u043e\u0435 \u0441 \u0433\u043d\u0435\u0437\u0434\u043e\u043c \u0443\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u043c\u043e\u0433\u043e \u043a\u0430\u043c\u043d\u044f \u0430\u043a\u0442\u0438\u0432\u043d\u043e\u0433\u043e \u0443\u043c\u0435\u043d\u0438\u044f. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                    ""frameType"": 4,
                    ""x"": 0,
                    ""y"": 3,
                    ""inventoryId"": ""Stash12"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 0,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/SiphonGem.png?scale=1&scaleIndex=0&w=1&h=1&v=3c8bba854543b5f696b81cc6517dbcf73"",
                    ""support"": false,
                    ""league"": ""Hardcore"",
                    ""id"": ""6261eb58d7cd12acc4dc938f353ca7ba12f37a3d2bf494c7dbef6e7b24e9b226"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""\u041f\u043e\u0445\u0438\u0449\u0435\u043d\u0438\u0435 \u0441\u0443\u0449\u043d\u043e\u0441\u0442\u0438"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0421\u043d\u0430\u0440\u044f\u0434, \u0427\u0430\u0440\u044b, \u0414\u043b\u0438\u0442\u0441\u044f, \u0425\u0430\u043e\u0441"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""1"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 5
                        },
                        {
                            ""name"": ""\u0420\u0430\u0441\u0445\u043e\u0434 \u043c\u0430\u043d\u044b"",
                            ""values"": [
                                [
                                    ""9"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0412\u0440\u0435\u043c\u044f \u043f\u0440\u0438\u043c\u0435\u043d\u0435\u043d\u0438\u044f"",
                            ""values"": [
                                [
                                    ""0.75 \u0441\u0435\u043a."",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0428\u0430\u043d\u0441 \u043a\u0440\u0438\u0442\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0434\u0430\u0440\u0430"",
                            ""values"": [
                                [
                                    ""5.00%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u042d\u0444\u0444\u0435\u043a\u0442\u0438\u0432\u043d\u043e\u0441\u0442\u044c \u0434\u043e\u0431\u0430\u0432\u043b\u0435\u043d\u043d\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430"",
                            ""values"": [
                                [
                                    ""60%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""additionalProperties"": [
                        {
                            ""name"": ""\u041e\u043f\u044b\u0442"",
                            ""values"": [
                                [
                                    ""1\/15249"",
                                    0
                                ]
                            ],
                            ""displayMode"": 2,
                            ""progress"": 6.557806773344055e-5
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""12"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041b\u043e\u0432\u043a"",
                            ""values"": [
                                [
                                    ""14"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        },
                        {
                            ""name"": ""\u0418\u043d\u0442"",
                            ""values"": [
                                [
                                    ""21"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""secDescrText"": ""\u0412\u044b\u043f\u0443\u0441\u043a\u0430\u0435\u0442 \u0441\u043d\u0430\u0440\u044f\u0434, \u043a\u043e\u0442\u043e\u0440\u044b\u0439 \u043d\u0430\u043a\u043b\u0430\u0434\u044b\u0432\u0430\u0435\u0442 \u043d\u0430 \u0432\u0440\u0430\u0433\u043e\u0432 \u043d\u0435\u0433\u0430\u0442\u0438\u0432\u043d\u044b\u0439 \u044d\u0444\u0444\u0435\u043a\u0442, \u043d\u0430\u043d\u043e\u0441\u044f\u0449\u0438\u0439 \u043f\u043e\u0441\u0442\u0435\u043f\u0435\u043d\u043d\u044b\u0439 \u0443\u0440\u043e\u043d. \u0412\u044b \u0438\u0441\u0446\u0435\u043b\u044f\u0435\u0442\u0435\u0441\u044c \u043d\u0430 \u0447\u0430\u0441\u0442\u044c \u043e\u0442 \u043d\u0430\u043d\u0435\u0441\u0451\u043d\u043d\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430. \u041d\u0435\u0433\u0430\u0442\u0438\u0432\u043d\u044b\u0439 \u044d\u0444\u0444\u0435\u043a\u0442 \u043f\u0435\u0440\u0435\u043d\u043e\u0441\u0438\u0442\u0441\u044f \u0432\u043c\u0435\u0441\u0442\u0435 \u0441 \u0418\u043d\u0444\u0435\u043a\u0446\u0438\u0435\u0439."",
                    ""explicitMods"": [
                        ""\u041d\u0430\u043d\u043e\u0441\u0438\u0442 \u043e\u0442 6 \u0434\u043e 9 \u0443\u0440\u043e\u043d\u0430 \u0445\u0430\u043e\u0441\u043e\u043c"",
                        ""\u041d\u0430\u043d\u043e\u0441\u0438\u0442 21.3 \u0431\u0430\u0437\u043e\u0432\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430 \u0445\u0430\u043e\u0441\u043e\u043c \u0432 \u0441\u0435\u043a\u0443\u043d\u0434\u0443"",
                        ""\u0411\u0430\u0437\u043e\u0432\u0430\u044f \u0434\u043b\u0438\u0442\u0435\u043b\u044c\u043d\u043e\u0441\u0442\u044c: 3.80 \u0441\u0435\u043a\u0443\u043d\u0434"",
                        ""\u041c\u043e\u0434\u0438\u0444\u0438\u043a\u0430\u0442\u043e\u0440\u044b \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u0447\u0430\u0440 \u043f\u0440\u0438\u043c\u0435\u043d\u044f\u044e\u0442\u0441\u044f \u043d\u0430 \u043f\u043e\u0441\u0442\u0435\u043f\u0435\u043d\u043d\u044b\u0439 \u0443\u0440\u043e\u043d \u044d\u0442\u043e\u0433\u043e \u0443\u043c\u0435\u043d\u0438\u044f"",
                        ""\u0420\u0435\u0433\u0435\u043d\u0435\u0440\u0438\u0440\u0443\u0435\u0442 0.50% \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u043e\u0442\u0440\u0438\u0446\u0430\u0442\u0435\u043b\u044c\u043d\u043e\u0433\u043e \u044d\u0444\u0444\u0435\u043a\u0442\u0430 \u0432 \u0432\u0438\u0434\u0435 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f""
                    ],
                    ""descrText"": ""\u0414\u043b\u044f \u043f\u043e\u043b\u0443\u0447\u0435\u043d\u0438\u044f \u0443\u043c\u0435\u043d\u0438\u044f \u0432\u044b\u0431\u0435\u0440\u0438\u0442\u0435 \u043f\u0440\u0435\u0434\u043c\u0435\u0442 \u0438 \u043f\u043e\u043c\u0435\u0441\u0442\u0438\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u0432 \u0433\u043d\u0435\u0437\u0434\u043e \u0441\u043e\u043e\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0443\u044e\u0449\u0435\u0433\u043e \u0446\u0432\u0435\u0442\u0430. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                    ""frameType"": 4,
                    ""x"": 0,
                    ""y"": 4,
                    ""inventoryId"": ""Stash13"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 2,
                    ""ilvl"": 68,
                    ""icon"": ""https:\/\/web.poecdn.com\/gen\/image\/YTo1OntzOjEwOiJsZWFn\/dWVOYW1lIjtzOjg6Ikhh\/cmRjb3JlIjtzOjk6ImFj\/Y291bnRJZCI7TzoxODoi\/R3JpbmRiXERhdGFiYXNl\/XElkIjoxOntzOjI6Imlk\/IjtpOjA7fWk6MjthOjM6\/e3M6MToiZiI7czozMzoi\/QXJ0LzJESXRlbXMvRmxh\/c2tzL2V2YXNpb25mbGFz\/azAxIjtzOjI6InNwIjtk\/OjAuNjA4NTE5MjY5Nzc2\/ODc2MztzOjU6ImxldmVs\/IjtpOjA7fWk6MTtpOjQ7\/aTowO2k6OTt9\/962406f429\/Item.png"",
                    ""league"": ""Hardcore"",
                    ""id"": ""dac306afc3a91e423e870c23aed8d944f38d29badd6c756645632a4e317bcbda"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""\u041d\u0435\u0444\u0440\u0438\u0442\u043e\u0432\u044b\u0439 \u0444\u043b\u0430\u043a\u043e\u043d"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0414\u043b\u0438\u0442\u0441\u044f %0 \u0441\u0435\u043a."",
                            ""values"": [
                                [
                                    ""4.00"",
                                    0
                                ]
                            ],
                            ""displayMode"": 3
                        },
                        {
                            ""name"": ""\u0420\u0430\u0441\u0445\u043e\u0434\u0443\u0435\u0442 %0 \u0438\u0437 %1 \u0437\u0430\u0440\u044f\u0434\u043e\u0432 \u043f\u0440\u0438 \u0438\u0441\u043f\u043e\u043b\u044c\u0437\u043e\u0432\u0430\u043d\u0438\u0438"",
                            ""values"": [
                                [
                                    ""30"",
                                    0
                                ],
                                [
                                    ""60"",
                                    0
                                ]
                            ],
                            ""displayMode"": 3
                        },
                        {
                            ""name"": ""\u0421\u043e\u0434\u0435\u0440\u0436\u0438\u0442 \u0437\u0430\u0440\u044f\u0434\u043e\u0432: %0"",
                            ""values"": [
                                [
                                    ""0"",
                                    0
                                ]
                            ],
                            ""displayMode"": 3
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""27"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""utilityMods"": [
                        ""+3000 \u043a \u0443\u043a\u043b\u043e\u043d\u0435\u043d\u0438\u044e""
                    ],
                    ""descrText"": ""\u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043f\u0438\u0442\u044c. \u0421\u043e\u0434\u0435\u0440\u0436\u0438\u0442 \u0437\u0430\u0440\u044f\u0434\u044b \u0442\u043e\u043b\u044c\u043a\u043e \u043a\u043e\u0433\u0434\u0430 \u0432\u0438\u0441\u0438\u0442 \u043d\u0430 \u043f\u043e\u044f\u0441\u0435. \u041f\u043e\u043f\u043e\u043b\u043d\u044f\u0435\u0442\u0441\u044f \u043f\u043e \u043c\u0435\u0440\u0435 \u0443\u0431\u0438\u0439\u0441\u0442\u0432\u0430 \u043c\u043e\u043d\u0441\u0442\u0440\u043e\u0432."",
                    ""frameType"": 0,
                    ""x"": 11,
                    ""y"": 8,
                    ""inventoryId"": ""Stash14"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 2,
                    ""ilvl"": 52,
                    ""icon"": ""https:\/\/web.poecdn.com\/gen\/image\/YTo1OntzOjEwOiJsZWFn\/dWVOYW1lIjtzOjg6Ikhh\/cmRjb3JlIjtzOjk6ImFj\/Y291bnRJZCI7TzoxODoi\/R3JpbmRiXERhdGFiYXNl\/XElkIjoxOntzOjI6Imlk\/IjtpOjA7fWk6MjthOjM6\/e3M6MToiZiI7czoyNToi\/QXJ0LzJESXRlbXMvRmxh\/c2tzL3NwcmludCI7czoy\/OiJzcCI7ZDowLjYwODUx\/OTI2OTc3Njg3NjM7czo1\/OiJsZXZlbCI7aTowO31p\/OjE7aTo0O2k6MDtpOjk7\/fQ,,\/06b229075c\/Item.png"",
                    ""league"": ""Hardcore"",
                    ""id"": ""8bfb9fb7925e3a40b89bf52d7edd1257afe19db1b8527a13c80e00b2d338b99c"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""<<set:MS>><<set:M>><<set:S>><if:MS>{\u0425\u0438\u0440\u0443\u0440\u0433\u0438\u0447\u0435\u0441\u043a\u0438\u0439
                    }<elif:FS>{\u0425\u0438\u0440\u0443\u0440\u0433\u0438\u0447\u0435\u0441\u043a\u0430\u044f
                    }<elif:NS>{\u0425\u0438\u0440\u0443\u0440\u0433\u0438\u0447\u0435\u0441\u043a\u043e\u0435
                    }<elif:MP>{\u0425\u0438\u0440\u0443\u0440\u0433\u0438\u0447\u0435\u0441\u043a\u0438\u0435
                    }<elif:FP>{\u0425\u0438\u0440\u0443\u0440\u0433\u0438\u0447\u0435\u0441\u043a\u0438\u0435
                    }<elif:NP>{\u0425\u0438\u0440\u0443\u0440\u0433\u0438\u0447\u0435\u0441\u043a\u0438\u0435
                    } \u0420\u0442\u0443\u0442\u043d\u044b\u0439 \u0444\u043b\u0430\u043a\u043e\u043d \u0430\u0434\u0440\u0435\u043d\u0430\u043b\u0438\u043d\u0430"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0414\u043b\u0438\u0442\u0441\u044f %0 \u0441\u0435\u043a."",
                            ""values"": [
                                [
                                    ""4.00"",
                                    0
                                ]
                            ],
                            ""displayMode"": 3
                        },
                        {
                            ""name"": ""\u0420\u0430\u0441\u0445\u043e\u0434\u0443\u0435\u0442 %0 \u0438\u0437 %1 \u0437\u0430\u0440\u044f\u0434\u043e\u0432 \u043f\u0440\u0438 \u0438\u0441\u043f\u043e\u043b\u044c\u0437\u043e\u0432\u0430\u043d\u0438\u0438"",
                            ""values"": [
                                [
                                    ""20"",
                                    0
                                ],
                                [
                                    ""50"",
                                    0
                                ]
                            ],
                            ""displayMode"": 3
                        },
                        {
                            ""name"": ""\u0421\u043e\u0434\u0435\u0440\u0436\u0438\u0442 \u0437\u0430\u0440\u044f\u0434\u043e\u0432: %0"",
                            ""values"": [
                                [
                                    ""0"",
                                    0
                                ]
                            ],
                            ""displayMode"": 3
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""6"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""utilityMods"": [
                        ""40% \u043f\u043e\u0432\u044b\u0448\u0435\u043d\u0438\u0435 \u0441\u043a\u043e\u0440\u043e\u0441\u0442\u0438 \u043f\u0435\u0440\u0435\u0434\u0432\u0438\u0436\u0435\u043d\u0438\u044f""
                    ],
                    ""explicitMods"": [
                        ""20% \u0448\u0430\u043d\u0441 \u043f\u043e\u043b\u0443\u0447\u0438\u0442\u044c \u0437\u0430\u0440\u044f\u0434 \u0444\u043b\u0430\u043a\u043e\u043d\u0430 \u043f\u0440\u0438 \u043d\u0430\u043d\u0435\u0441\u0435\u043d\u0438\u0438 \u043a\u0440\u0438\u0442\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0434\u0430\u0440\u0430"",
                        ""24% \u043f\u043e\u0432\u044b\u0448\u0435\u043d\u0438\u0435 \u0441\u043a\u043e\u0440\u043e\u0441\u0442\u0438 \u043f\u0435\u0440\u0435\u0434\u0432\u0438\u0436\u0435\u043d\u0438\u044f \u0432\u043e \u0432\u0440\u0435\u043c\u044f \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044f \u044d\u0444\u0444\u0435\u043a\u0442\u0430 \u0444\u043b\u0430\u043a\u043e\u043d\u0430""
                    ],
                    ""descrText"": ""\u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043f\u0438\u0442\u044c. \u0421\u043e\u0434\u0435\u0440\u0436\u0438\u0442 \u0437\u0430\u0440\u044f\u0434\u044b \u0442\u043e\u043b\u044c\u043a\u043e \u043a\u043e\u0433\u0434\u0430 \u0432\u0438\u0441\u0438\u0442 \u043d\u0430 \u043f\u043e\u044f\u0441\u0435. \u041f\u043e\u043f\u043e\u043b\u043d\u044f\u0435\u0442\u0441\u044f \u043f\u043e \u043c\u0435\u0440\u0435 \u0443\u0431\u0438\u0439\u0441\u0442\u0432\u0430 \u043c\u043e\u043d\u0441\u0442\u0440\u043e\u0432."",
                    ""frameType"": 1,
                    ""x"": 11,
                    ""y"": 10,
                    ""inventoryId"": ""Stash15"",
                    ""socketedItems"": [
                        
                    ]
                }
            ],
            ""public"": true
        },
        {
            ""accountName"": ""XiaZ"",
            ""lastCharacterName"": """",
            ""id"": ""26d5794e1134381e8b826caa88c51895154093568b992d5c41d6104f3a8e57ed"",
            ""stash"": ""~b\/o 1 fuse"",
            ""stashType"": ""PremiumStash"",
            ""items"": [
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 0,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/Vulnerability.png?scale=1&scaleIndex=0&w=1&h=1&v=d5e4ae8c4fa14e3b4c870e0caa0177513"",
                    ""support"": false,
                    ""league"": ""Hardcore"",
                    ""id"": ""8a05f59f0f8f36bcdaf7b8937e662be927af310932d9ee7c39c8fe9305a69269"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""\u0411\u0435\u0437\u0437\u0430\u0449\u0438\u0442\u043d\u043e\u0441\u0442\u044c"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u041f\u0440\u043e\u043a\u043b\u044f\u0442\u044c\u0435, \u0427\u0430\u0440\u044b, \u041e\u0431\u043b\u0430\u0441\u0442\u044c, \u0414\u043b\u0438\u0442\u0441\u044f"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""1"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 5
                        },
                        {
                            ""name"": ""\u0420\u0430\u0441\u0445\u043e\u0434 \u043c\u0430\u043d\u044b"",
                            ""values"": [
                                [
                                    ""24"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0412\u0440\u0435\u043c\u044f \u043f\u0440\u0438\u043c\u0435\u043d\u0435\u043d\u0438\u044f"",
                            ""values"": [
                                [
                                    ""0.50 \u0441\u0435\u043a."",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041a\u0430\u0447\u0435\u0441\u0442\u0432\u043e"",
                            ""values"": [
                                [
                                    ""+8%"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 6
                        }
                    ],
                    ""additionalProperties"": [
                        {
                            ""name"": ""\u041e\u043f\u044b\u0442"",
                            ""values"": [
                                [
                                    ""1\/118383"",
                                    0
                                ]
                            ],
                            ""displayMode"": 2,
                            ""progress"": 8.447158506896812e-6
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""24"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0418\u043d\u0442"",
                            ""values"": [
                                [
                                    ""58"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""secDescrText"": ""\u0413\u0435\u0440\u043e\u0439 \u043f\u0440\u043e\u043a\u043b\u0438\u043d\u0430\u0435\u0442 \u0432\u0441\u0435\u0445 \u0432\u0440\u0430\u0433\u043e\u0432 \u0432 \u043e\u0431\u043b\u0430\u0441\u0442\u0438 \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044f \u043d\u0430\u0432\u044b\u043a\u0430, \u043f\u043e\u0432\u044b\u0448\u0430\u044f \u043f\u043e\u043b\u0443\u0447\u0430\u0435\u043c\u044b\u0439 \u0438\u043c\u0438 \u0444\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u0438\u0439 \u0438 \u043f\u043e\u0441\u0442\u0435\u043f\u0435\u043d\u043d\u044b\u0439 \u0443\u0440\u043e\u043d."",
                    ""explicitMods"": [
                        ""\u0411\u0430\u0437\u043e\u0432\u0430\u044f \u0434\u043b\u0438\u0442\u0435\u043b\u044c\u043d\u043e\u0441\u0442\u044c: 9.00 \u0441\u0435\u043a\u0443\u043d\u0434"",
                        ""\u041f\u043e\u043b\u0443\u0447\u0430\u0435\u043c\u044b\u0439 \u043f\u0440\u043e\u043a\u043b\u044f\u0442\u044b\u043c\u0438 \u0432\u0440\u0430\u0433\u0430\u043c\u0438 \u043f\u043e\u0441\u0442\u0435\u043f\u0435\u043d\u043d\u044b\u0439 \u0443\u0440\u043e\u043d \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d \u043d\u0430 33%"",
                        ""\u041f\u043e\u043b\u0443\u0447\u0430\u0435\u043c\u044b\u0439 \u043f\u0440\u043e\u043a\u043b\u044f\u0442\u044b\u043c\u0438 \u0432\u0440\u0430\u0433\u0430\u043c\u0438 \u0444\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u0438\u0439 \u0443\u0440\u043e\u043d \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d \u043d\u0430 24%""
                    ],
                    ""descrText"": ""\u0414\u043b\u044f \u043f\u043e\u043b\u0443\u0447\u0435\u043d\u0438\u044f \u0443\u043c\u0435\u043d\u0438\u044f \u0432\u044b\u0431\u0435\u0440\u0438\u0442\u0435 \u043f\u0440\u0435\u0434\u043c\u0435\u0442 \u0438 \u043f\u043e\u043c\u0435\u0441\u0442\u0438\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u0432 \u0433\u043d\u0435\u0437\u0434\u043e \u0441\u043e\u043e\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0443\u044e\u0449\u0435\u0433\u043e \u0446\u0432\u0435\u0442\u0430. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                    ""frameType"": 4,
                    ""x"": 8,
                    ""y"": 4,
                    ""inventoryId"": ""Stash1"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 0,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/IceShot.png?scale=1&scaleIndex=0&w=1&h=1&v=c34f8fc5f4532dd7d9c0e36d995914383"",
                    ""support"": false,
                    ""league"": ""Hardcore"",
                    ""id"": ""2bb8581a882260623b937a138410ba7cf369324499e94ecddd2b1f966df04748"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""\u041b\u0435\u0434\u044f\u043d\u043e\u0439 \u0432\u044b\u0441\u0442\u0440\u0435\u043b"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0410\u0442\u0430\u043a\u0430, \u041e\u0431\u043b\u0430\u0441\u0442\u044c, \u0414\u043b\u0438\u0442\u0441\u044f, \u0425\u043e\u043b\u043e\u0434, \u041b\u0443\u043a"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""1"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 5
                        },
                        {
                            ""name"": ""\u0420\u0430\u0441\u0445\u043e\u0434 \u043c\u0430\u043d\u044b"",
                            ""values"": [
                                [
                                    ""6"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u042d\u0444\u0444\u0435\u043a\u0442\u0438\u0432\u043d\u043e\u0441\u0442\u044c \u0434\u043e\u0431\u0430\u0432\u043b\u0435\u043d\u043d\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430"",
                            ""values"": [
                                [
                                    ""120%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041a\u0430\u0447\u0435\u0441\u0442\u0432\u043e"",
                            ""values"": [
                                [
                                    ""+5%"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 6
                        }
                    ],
                    ""additionalProperties"": [
                        {
                            ""name"": ""\u041e\u043f\u044b\u0442"",
                            ""values"": [
                                [
                                    ""1\/70"",
                                    0
                                ]
                            ],
                            ""displayMode"": 2,
                            ""progress"": 0.014285714365541935
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""1"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""secDescrText"": ""\u0413\u0435\u0440\u043e\u0439 \u043f\u0443\u0441\u043a\u0430\u0435\u0442 \u0441\u0442\u0440\u0435\u043b\u0443, \u043a\u043e\u0442\u043e\u0440\u0430\u044f \u043d\u0430\u043d\u043e\u0441\u0438\u0442 \u0446\u0435\u043b\u0438 \u0444\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u0438\u0439 \u0443\u0440\u043e\u043d, \u0447\u0430\u0441\u0442\u044c \u043a\u043e\u0442\u043e\u0440\u043e\u0433\u043e \u043f\u0440\u0435\u0432\u0440\u0430\u0449\u0430\u0435\u0442 \u0432 \u0443\u0440\u043e\u043d \u043e\u0442 \u0445\u043e\u043b\u043e\u0434\u0430. \u041a\u0440\u043e\u043c\u0435 \u0442\u043e\u0433\u043e, \u043e\u043d\u0430 \u0441\u043e\u0437\u0434\u0430\u0435\u0442 \u043a\u043e\u043d\u0443\u0441\u043e\u043e\u0431\u0440\u0430\u0437\u043d\u0443\u044e \u043e\u0431\u043b\u0430\u0441\u0442\u044c \u043f\u043e\u0440\u0430\u0436\u0435\u043d\u0438\u044f \u0437\u0430 \u0446\u0435\u043b\u044c\u044e, \u043f\u0440\u0435\u043e\u0431\u0440\u0430\u0437\u0443\u0435\u0442 \u0432\u0435\u0441\u044c \u0444\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u0438\u0439 \u0443\u0440\u043e\u043d \u0432 \u0443\u0440\u043e\u043d \u043e\u0442 \u0445\u043e\u043b\u043e\u0434\u0430 \u0438 \u043d\u0430\u043d\u043e\u0441\u0438\u0442 \u0435\u0433\u043e \u043f\u043e\u043f\u0430\u0432\u0448\u0438\u043c \u0432 \u043e\u0431\u043b\u0430\u0441\u0442\u044c \u0432\u0440\u0430\u0433\u0430\u043c. \u0417\u0435\u043c\u043b\u044f \u043f\u043e\u0434 \u0446\u0435\u043b\u044c\u044e \u043f\u043e\u043a\u0440\u044b\u0432\u0430\u0435\u0442\u0441\u044f \u043b\u044c\u0434\u043e\u043c."",
                    ""explicitMods"": [
                        ""60% \u0444\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430 \u0441\u0442\u0430\u043d\u043e\u0432\u0438\u0442\u0441\u044f \u0443\u0440\u043e\u043d\u043e\u043c \u043e\u0442 \u0445\u043e\u043b\u043e\u0434\u0430"",
                        ""\u0411\u0430\u0437\u043e\u0432\u0430\u044f \u0434\u043b\u0438\u0442\u0435\u043b\u044c\u043d\u043e\u0441\u0442\u044c: 1.50 \u0441\u0435\u043a\u0443\u043d\u0434"",
                        ""\u041d\u0430\u043d\u043e\u0441\u0438\u0442 120% \u043e\u0442 \u0431\u0430\u0437\u043e\u0432\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430"",
                        ""5% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u0445\u043e\u043b\u043e\u0434\u0430""
                    ],
                    ""descrText"": ""\u0414\u043b\u044f \u043f\u043e\u043b\u0443\u0447\u0435\u043d\u0438\u044f \u0443\u043c\u0435\u043d\u0438\u044f \u0432\u044b\u0431\u0435\u0440\u0438\u0442\u0435 \u043f\u0440\u0435\u0434\u043c\u0435\u0442 \u0438 \u043f\u043e\u043c\u0435\u0441\u0442\u0438\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u0432 \u0433\u043d\u0435\u0437\u0434\u043e \u0441\u043e\u043e\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0443\u044e\u0449\u0435\u0433\u043e \u0446\u0432\u0435\u0442\u0430. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                    ""frameType"": 4,
                    ""x"": 1,
                    ""y"": 11,
                    ""inventoryId"": ""Stash2"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 2,
                    ""h"": 2,
                    ""ilvl"": 68,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Armours\/Boots\/DarkrayVectors.png?scale=1&scaleIndex=0&w=2&h=2&v=6ddb5285ab1bd32a565dea229c97feed3"",
                    ""league"": ""Hardcore"",
                    ""id"": ""15b5327cbaceef0289eb2a832995314915c6789436cf440465efc88a8290f8e7"",
                    ""sockets"": [
                        {
                            ""group"": 0,
                            ""attr"": ""S""
                        },
                        {
                            ""group"": 0,
                            ""attr"": ""D""
                        }
                    ],
                    ""name"": ""<<set:MP>><<set:M>><<set:P>>\u041d\u0435\u0441\u0443\u0449\u0438\u0435 \u0442\u044c\u043c\u0443"",
                    ""typeLine"": ""\u0411\u043e\u0442\u0438\u043d\u043a\u0438 \u0438\u0437 \u0447\u0435\u0448\u0443\u0438 \u0434\u0440\u0430\u043a\u043e\u043d\u0430"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0411\u0440\u043e\u043d\u044f"",
                            ""values"": [
                                [
                                    ""121"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 16
                        },
                        {
                            ""name"": ""\u0423\u043a\u043b\u043e\u043d\u0435\u043d\u0438\u0435"",
                            ""values"": [
                                [
                                    ""121"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 17
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""65"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0421\u0438\u043b\u0430"",
                            ""values"": [
                                [
                                    ""62"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        },
                        {
                            ""name"": ""\u041b\u043e\u0432\u043a"",
                            ""values"": [
                                [
                                    ""62"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""explicitMods"": [
                        ""+35% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u043c\u043e\u043b\u043d\u0438\u0438"",
                        ""5% \u043f\u043e\u0432\u044b\u0448\u0435\u043d\u0438\u0435 \u0441\u043a\u043e\u0440\u043e\u0441\u0442\u0438 \u043f\u0435\u0440\u0435\u0434\u0432\u0438\u0436\u0435\u043d\u0438\u044f \u0437\u0430 \u0437\u0430\u0440\u044f\u0434 \u044f\u0440\u043e\u0441\u0442\u0438"",
                        ""+1 \u043a \u043c\u0430\u043a\u0441\u0438\u043c\u0443\u043c\u0443 \u0437\u0430\u0440\u044f\u0434\u043e\u0432 \u044f\u0440\u043e\u0441\u0442\u0438"",
                        ""50% \u0443\u043c\u0435\u043d\u044c\u0448\u0435\u043d\u0438\u0435 \u0434\u043b\u0438\u0442\u0435\u043b\u044c\u043d\u043e\u0441\u0442\u0438 \u0437\u0430\u0440\u044f\u0434\u0430 \u044f\u0440\u043e\u0441\u0442\u0438"",
                        ""25% \u0443\u043c\u0435\u043d\u044c\u0448\u0435\u043d\u0438\u0435 \u0440\u0430\u0434\u0438\u0443\u0441\u0430 \u043e\u0431\u0437\u043e\u0440\u0430"",
                        ""2% \u043a \u0448\u0430\u043d\u0441\u0443 \u0443\u0432\u0435\u0440\u043d\u0443\u0442\u044c\u0441\u044f \u043e\u0442 \u0430\u0442\u0430\u043a \u0437\u0430 \u0437\u0430\u0440\u044f\u0434 \u044f\u0440\u043e\u0441\u0442\u0438""
                    ],
                    ""flavourText"": [
                        ""\u00ab\u0421\u0438\u0440\u0440\u0438\u0443\u0441 \u043b\u0435\u0442\u0435\u043b \u043d\u0430 \u043a\u0440\u044b\u043b\u044c\u044f\u0445 \u0441\u0432\u0435\u0442\u0430: \u0431\u044b\u0441\u0442\u0440\u0435\u0435 \u0432\u0435\u0442\u0440\u0430,\r"",
                        ""\u0431\u044b\u0441\u0442\u0440\u0435\u0435 \u043c\u044b\u0441\u043b\u0438. \u041d\u043e \u0437\u0440\u044f \u043e\u043d \u043f\u044b\u0442\u0430\u043b\u0441\u044f \u043e\u0431\u043e\u0433\u043d\u0430\u0442\u044c \u0442\u044c\u043c\u0443:\r"",
                        ""\u043e\u043d\u0430 \u0431\u044b\u043b\u0430 \u0440\u044f\u0434\u043e\u043c, \u0436\u0434\u0430\u043b\u0430 \u0435\u0433\u043e \u0437\u0430 \u043a\u0430\u0436\u0434\u044b\u043c \u043f\u043e\u0432\u043e\u0440\u043e\u0442\u043e\u043c\u00bb.\r"",
                        ""- \u0418\u0437 \u0441\u043a\u0430\u0437\u0430\u043d\u0438\u0439 \u0430\u0437\u043c\u0438\u0440\u0438""
                    ],
                    ""frameType"": 3,
                    ""x"": 0,
                    ""y"": 4,
                    ""inventoryId"": ""Stash3"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 2,
                    ""h"": 3,
                    ""ilvl"": 69,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Armours\/BodyArmours\/BodyStrInt2C.png?scale=1&scaleIndex=0&w=2&h=3&v=da51dd4c9ab2a0ddb4ea9e2edc4fb6b33"",
                    ""league"": ""Hardcore"",
                    ""id"": ""9d089e1fd53ba860691fcbba9d977002fae2864d4ad4cbf9a6205cc0e9cb88bf"",
                    ""sockets"": [
                        {
                            ""group"": 0,
                            ""attr"": ""S""
                        }
                    ],
                    ""name"": ""<<set:MS>><<set:M>><<set:S>><if:MS>{\u0412\u0435\u0449\u0438\u0439
                    }<elif:FS>{\u0412\u0435\u0449\u0430\u044f
                    }<elif:NS>{\u0412\u0435\u0449\u0435\u0435
                    }<elif:MP>{\u0412\u0435\u0449\u0438\u0435
                    }<elif:FP>{\u0412\u0435\u0449\u0438\u0435
                    }<elif:NP>{\u0412\u0435\u0449\u0438\u0435
                    } \u043f\u043e\u043a\u0440\u043e\u0432"",
                    ""typeLine"": ""\u0425\u0430\u0443\u0431\u0435\u0440\u0433 \u0441\u0432\u044f\u0442\u043e\u0433\u043e"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0411\u0440\u043e\u043d\u044f"",
                            ""values"": [
                                [
                                    ""762"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 16
                        },
                        {
                            ""name"": ""\u042d\u043d\u0435\u0440\u0433\u0435\u0442\u0438\u0447\u0435\u0441\u043a\u0438\u0439 \u0449\u0438\u0442"",
                            ""values"": [
                                [
                                    ""306"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 18
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""67"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0421\u0438\u043b\u0430"",
                            ""values"": [
                                [
                                    ""109"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        },
                        {
                            ""name"": ""\u0418\u043d\u0442"",
                            ""values"": [
                                [
                                    ""94"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""explicitMods"": [
                        ""+23 \u043a \u0438\u043d\u0442\u0435\u043b\u043b\u0435\u043a\u0442\u0443"",
                        ""72% \u043f\u043e\u0432\u044b\u0448\u0435\u043d\u0438\u0435 \u0431\u0440\u043e\u043d\u0438 \u0438 \u044d\u043d\u0435\u0440\u0433\u0435\u0442\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0449\u0438\u0442\u0430"",
                        ""+105 \u043a \u043c\u0430\u043a\u0441\u0438\u043c\u0443\u043c\u0443 \u044d\u043d\u0435\u0440\u0433\u0435\u0442\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0449\u0438\u0442\u0430"",
                        ""+35% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u043c\u043e\u043b\u043d\u0438\u0438"",
                        ""+20% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u0445\u0430\u043e\u0441\u0443""
                    ],
                    ""frameType"": 2,
                    ""x"": 8,
                    ""y"": 7,
                    ""inventoryId"": ""Stash4"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 2,
                    ""h"": 2,
                    ""ilvl"": 69,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Armours\/Shields\/ShieldInt3.png?scale=1&scaleIndex=0&w=2&h=2&v=0b4ca72b3f1678f750402c910c3fb09c3"",
                    ""league"": ""Hardcore"",
                    ""id"": ""72223b97af0178cbe16d4f891a1d0a68e3a8b06b49ffddf88f440c326b5d7d2c"",
                    ""sockets"": [
                        {
                            ""group"": 0,
                            ""attr"": ""I""
                        },
                        {
                            ""group"": 0,
                            ""attr"": ""D""
                        },
                        {
                            ""group"": 1,
                            ""attr"": ""S""
                        }
                    ],
                    ""name"": ""<<set:FS>><<set:F>><<set:S>><if:MS>{\u0411\u043b\u0430\u0433\u043e\u0439
                    }<elif:FS>{\u0411\u043b\u0430\u0433\u0430\u044f
                    }<elif:NS>{\u0411\u043b\u0430\u0433\u043e\u0435
                    }<elif:MP>{\u0411\u043b\u0430\u0433\u0438\u0435
                    }<elif:FP>{\u0411\u043b\u0430\u0433\u0438\u0435
                    }<elif:NP>{\u0411\u043b\u0430\u0433\u0438\u0435
                    } \u043f\u0435\u0441\u043d\u044c"",
                    ""typeLine"": ""\u0429\u0438\u0442 \u0434\u0443\u0445\u0430 \u0438\u0437 \u0441\u0442\u0430\u0440\u044b\u0445 \u043a\u043e\u0441\u0442\u0435\u0439"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0428\u0430\u043d\u0441 \u0437\u0430\u0431\u043b\u043e\u043a\u0438\u0440\u043e\u0432\u0430\u0442\u044c \u0443\u0434\u0430\u0440"",
                            ""values"": [
                                [
                                    ""22%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 15
                        },
                        {
                            ""name"": ""\u042d\u043d\u0435\u0440\u0433\u0435\u0442\u0438\u0447\u0435\u0441\u043a\u0438\u0439 \u0449\u0438\u0442"",
                            ""values"": [
                                [
                                    ""33"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 18
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""41"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0418\u043d\u0442"",
                            ""values"": [
                                [
                                    ""100"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""implicitMods"": [
                        ""15% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u0447\u0430\u0440""
                    ],
                    ""explicitMods"": [
                        ""+60 \u043a \u043c\u0430\u043a\u0441\u0438\u043c\u0443\u043c\u0443 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f"",
                        ""+28 \u043a \u043c\u0430\u043a\u0441\u0438\u043c\u0443\u043c\u0443 \u043c\u0430\u043d\u044b"",
                        ""+14% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u0432\u0441\u0435\u043c \u0441\u0442\u0438\u0445\u0438\u044f\u043c"",
                        ""+29% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u043e\u0433\u043d\u044e""
                    ],
                    ""craftedMods"": [
                        ""+21% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u0445\u043e\u043b\u043e\u0434\u0443""
                    ],
                    ""frameType"": 2,
                    ""x"": 6,
                    ""y"": 10,
                    ""inventoryId"": ""Stash5"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 0,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/Support\/AddedLightningDamage.png?scale=1&scaleIndex=0&w=1&h=1&v=9228c011d886459c66e66caa1d3e6fb13"",
                    ""support"": true,
                    ""league"": ""Hardcore"",
                    ""id"": ""bc543066bb63b089c1316c386e5b9780990e7f32c65cd420c8bda570decbc0df"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""\u0423\u0440\u043e\u043d \u043c\u043e\u043b\u043d\u0438\u0435\u0439"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u041c\u043e\u043b\u043d\u0438\u044f, \u041f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0430"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""1"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 5
                        },
                        {
                            ""name"": ""\u041c\u043d\u043e\u0436\u0438\u0442\u0435\u043b\u044c \u043c\u0430\u043d\u044b"",
                            ""values"": [
                                [
                                    ""130%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""additionalProperties"": [
                        {
                            ""name"": ""\u041e\u043f\u044b\u0442"",
                            ""values"": [
                                [
                                    ""1\/3231"",
                                    0
                                ]
                            ],
                            ""displayMode"": 2,
                            ""progress"": 0.000309501716401428
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""8"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0418\u043d\u0442"",
                            ""values"": [
                                [
                                    ""18"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""secDescrText"": ""\u0423\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u0442 \u043b\u044e\u0431\u043e\u0435 \u0443\u043c\u0435\u043d\u0438\u0435, \u043d\u0430\u043d\u043e\u0441\u044f\u0449\u0435\u0435 \u0443\u0434\u0430\u0440\u044b \u043f\u043e \u0432\u0440\u0430\u0433\u0430\u043c."",
                    ""explicitMods"": [
                        ""\u0423\u0441\u0438\u043b\u0435\u043d\u043d\u044b\u0435 \u0443\u043c\u0435\u043d\u0438\u044f \u0438\u043c\u0435\u044e\u0442 \u043e\u0442 1 \u0434\u043e 8 \u0434\u043e\u0431\u0430\u0432\u043b\u0435\u043d\u043d\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u043c\u043e\u043b\u043d\u0438\u0438""
                    ],
                    ""descrText"": ""\u042d\u0442\u043e \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438. \u041e\u043d \u0434\u0430\u0435\u0442 \u043f\u0440\u0435\u0438\u043c\u0443\u0449\u0435\u0441\u0442\u0432\u0430 \u043d\u0435 \u0433\u0435\u0440\u043e\u044e, \u0430 \u043a\u0430\u043c\u043d\u044e \u0443\u043c\u0435\u043d\u0438\u044f \u0432 \u0441\u0432\u044f\u0437\u0430\u043d\u043d\u044b\u0445 \u0433\u043d\u0435\u0437\u0434\u0430\u0445. \u0412\u0441\u0442\u0430\u0432\u044c\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438 \u0432 \u0433\u043d\u0435\u0437\u0434\u043e, \u0441\u043e\u0435\u0434\u0438\u043d\u0435\u043d\u043d\u043e\u0435 \u0441 \u0433\u043d\u0435\u0437\u0434\u043e\u043c \u0443\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u043c\u043e\u0433\u043e \u043a\u0430\u043c\u043d\u044f \u0430\u043a\u0442\u0438\u0432\u043d\u043e\u0433\u043e \u0443\u043c\u0435\u043d\u0438\u044f. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                    ""frameType"": 4,
                    ""x"": 9,
                    ""y"": 5,
                    ""inventoryId"": ""Stash6"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 3,
                    ""ilvl"": 56,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Weapons\/OneHandWeapons\/Wands\/Wand6.png?scale=1&scaleIndex=0&w=1&h=3&v=54ba351a078c22737d02dfcec84665853"",
                    ""league"": ""Hardcore"",
                    ""id"": ""0494e0da35ccc8a97d025411a72200afd50ea8666a798156a87f1b0b8da0edab"",
                    ""sockets"": [
                        {
                            ""group"": 0,
                            ""attr"": ""I""
                        },
                        {
                            ""group"": 1,
                            ""attr"": ""I""
                        }
                    ],
                    ""name"": ""<<set:MP>><<set:M>><<set:P>><if:MS>{\u0414\u0440\u0430\u043a\u043e\u043d\u0438\u0439
                    }<elif:FS>{\u0414\u0440\u0430\u043a\u043e\u043d\u044c\u044f
                    }<elif:NS>{\u0414\u0440\u0430\u043a\u043e\u043d\u044c\u0435
                    }<elif:MP>{\u0414\u0440\u0430\u043a\u043e\u043d\u044c\u0438
                    }<elif:FP>{\u0414\u0440\u0430\u043a\u043e\u043d\u044c\u0438
                    }<elif:NP>{\u0414\u0440\u0430\u043a\u043e\u043d\u044c\u0438
                    } \u0432\u043e\u043f\u043b\u0438"",
                    ""typeLine"": ""\u0416\u0435\u0437\u043b \u043f\u0440\u043e\u0432\u0438\u0434\u0446\u0430"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0416\u0435\u0437\u043b"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0424\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u0438\u0439 \u0443\u0440\u043e\u043d"",
                            ""values"": [
                                [
                                    ""39-73"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 9
                        },
                        {
                            ""name"": ""\u0423\u0440\u043e\u043d \u043e\u0442 \u0441\u0442\u0438\u0445\u0438\u0439"",
                            ""values"": [
                                [
                                    ""13-27"",
                                    5
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 10
                        },
                        {
                            ""name"": ""\u0428\u0430\u043d\u0441 \u043a\u0440\u0438\u0442\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0434\u0430\u0440\u0430"",
                            ""values"": [
                                [
                                    ""8.00%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 12
                        },
                        {
                            ""name"": ""\u0410\u0442\u0430\u043a \u0432 \u0441\u0435\u043a\u0443\u043d\u0434\u0443"",
                            ""values"": [
                                [
                                    ""1.20"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 13
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""30"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0418\u043d\u0442"",
                            ""values"": [
                                [
                                    ""119"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""implicitMods"": [
                        ""11% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u0447\u0430\u0440""
                    ],
                    ""explicitMods"": [
                        ""31% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0444\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430"",
                        ""\u0414\u043e\u0431\u0430\u0432\u043b\u044f\u0435\u0442 \u043e\u0442 11 \u0434\u043e 21 \u0444\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430"",
                        ""\u0414\u043e\u0431\u0430\u0432\u043b\u044f\u0435\u0442 \u043e\u0442 13 \u0434\u043e 27 \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u0445\u043e\u043b\u043e\u0434\u0430"",
                        ""13% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u043c\u043e\u043b\u043d\u0438\u0438""
                    ],
                    ""frameType"": 2,
                    ""x"": 0,
                    ""y"": 9,
                    ""inventoryId"": ""Stash7"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 2,
                    ""h"": 4,
                    ""ilvl"": 56,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Weapons\/TwoHandWeapons\/Staves\/Staff7.png?scale=1&scaleIndex=0&w=2&h=4&v=2718b1cdd8edb75efd7fb3a84478f18d3"",
                    ""league"": ""Hardcore"",
                    ""id"": ""318f156297057ee554a93a2446c24a4f0842a8466d96120cdd4d370e25655a08"",
                    ""sockets"": [
                        {
                            ""group"": 0,
                            ""attr"": ""S""
                        },
                        {
                            ""group"": 1,
                            ""attr"": ""I""
                        },
                        {
                            ""group"": 2,
                            ""attr"": ""D""
                        }
                    ],
                    ""name"": ""<<set:MS>><<set:M>><<set:S>><if:MS>{\u0420\u043e\u043a\u043e\u0432\u043e\u0439
                    }<elif:FS>{\u0420\u043e\u043a\u043e\u0432\u0430\u044f
                    }<elif:NS>{\u0420\u043e\u043a\u043e\u0432\u043e\u0435
                    }<elif:MP>{\u0420\u043e\u043a\u043e\u0432\u044b\u0435
                    }<elif:FP>{\u0420\u043e\u043a\u043e\u0432\u044b\u0435
                    }<elif:NP>{\u0420\u043e\u043a\u043e\u0432\u044b\u0435
                    } \u0448\u0435\u0441\u0442"",
                    ""typeLine"": ""\u041f\u043e\u0441\u043e\u0445 \u043f\u0430\u0434\u0448\u0435\u0433\u043e"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u041f\u043e\u0441\u043e\u0445"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0424\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u0438\u0439 \u0443\u0440\u043e\u043d"",
                            ""values"": [
                                [
                                    ""123-230"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 9
                        },
                        {
                            ""name"": ""\u0428\u0430\u043d\u0441 \u043a\u0440\u0438\u0442\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0434\u0430\u0440\u0430"",
                            ""values"": [
                                [
                                    ""6.95%"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 12
                        },
                        {
                            ""name"": ""\u0410\u0442\u0430\u043a \u0432 \u0441\u0435\u043a\u0443\u043d\u0434\u0443"",
                            ""values"": [
                                [
                                    ""1.25"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 13
                        },
                        {
                            ""name"": ""\u0414\u0430\u043b\u044c\u043d\u043e\u0441\u0442\u044c \u043e\u0440\u0443\u0436\u0438\u044f"",
                            ""values"": [
                                [
                                    ""11"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 14
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""55"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0421\u0438\u043b\u0430"",
                            ""values"": [
                                [
                                    ""94"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        },
                        {
                            ""name"": ""\u0418\u043d\u0442"",
                            ""values"": [
                                [
                                    ""94"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""implicitMods"": [
                        ""12% \u0448\u0430\u043d\u0441 \u0431\u043b\u043e\u043a\u0430""
                    ],
                    ""explicitMods"": [
                        ""123% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0444\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430"",
                        ""14% \u043f\u043e\u0432\u044b\u0448\u0435\u043d\u0438\u0435 \u0448\u0430\u043d\u0441\u0430 \u043a\u0440\u0438\u0442\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0434\u0430\u0440\u0430"",
                        ""35% \u043f\u043e\u0432\u044b\u0448\u0435\u043d\u0438\u0435 \u0441\u043a\u043e\u0440\u043e\u0441\u0442\u0438 \u0440\u0435\u0433\u0435\u043d\u0435\u0440\u0430\u0446\u0438\u0438 \u043c\u0430\u043d\u044b"",
                        ""+18 \u043a \u043c\u0435\u0442\u043a\u043e\u0441\u0442\u0438""
                    ],
                    ""frameType"": 2,
                    ""x"": 6,
                    ""y"": 0,
                    ""inventoryId"": ""Stash8"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 3,
                    ""ilvl"": 64,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Weapons\/OneHandWeapons\/OneHandSwords\/OneHandSword2.png?scale=1&scaleIndex=0&w=1&h=3&v=a94ce74a6007ca561bb3a4bfa3abe15b3"",
                    ""league"": ""Hardcore"",
                    ""id"": ""8775fbbd737adba67ec5e194189067b71ac6690d64b6d61534d5cbd79f8b58d5"",
                    ""sockets"": [
                        {
                            ""group"": 0,
                            ""attr"": ""S""
                        },
                        {
                            ""group"": 1,
                            ""attr"": ""D""
                        }
                    ],
                    ""name"": ""<<set:MS>><<set:M>><<set:S>><if:MS>{\u0412\u0430\u043c\u043f\u0438\u0440\u0441\u043a\u0438\u0439
                    }<elif:FS>{\u0412\u0430\u043c\u043f\u0438\u0440\u0441\u043a\u0430\u044f
                    }<elif:NS>{\u0412\u0430\u043c\u043f\u0438\u0440\u0441\u043a\u043e\u0435
                    }<elif:MP>{\u0412\u0430\u043c\u043f\u0438\u0440\u0441\u043a\u0438\u0435
                    }<elif:FP>{\u0412\u0430\u043c\u043f\u0438\u0440\u0441\u043a\u0438\u0435
                    }<elif:NP>{\u0412\u0430\u043c\u043f\u0438\u0440\u0441\u043a\u0438\u0435
                    } \u0441\u0440\u0435\u0437"",
                    ""typeLine"": ""\u0421\u0430\u043c\u043e\u0446\u0432\u0435\u0442\u043d\u044b\u0439 \u043c\u0435\u0447"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u041e\u0434\u043d\u043e\u0440\u0443\u0447\u043d\u044b\u0439 \u043c\u0435\u0447"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0424\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u0438\u0439 \u0443\u0440\u043e\u043d"",
                            ""values"": [
                                [
                                    ""85-174"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 9
                        },
                        {
                            ""name"": ""\u0423\u0440\u043e\u043d \u043e\u0442 \u0441\u0442\u0438\u0445\u0438\u0439"",
                            ""values"": [
                                [
                                    ""5-12"",
                                    4
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 10
                        },
                        {
                            ""name"": ""\u0428\u0430\u043d\u0441 \u043a\u0440\u0438\u0442\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0434\u0430\u0440\u0430"",
                            ""values"": [
                                [
                                    ""5.00%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 12
                        },
                        {
                            ""name"": ""\u0410\u0442\u0430\u043a \u0432 \u0441\u0435\u043a\u0443\u043d\u0434\u0443"",
                            ""values"": [
                                [
                                    ""1.30"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 13
                        },
                        {
                            ""name"": ""\u0414\u0430\u043b\u044c\u043d\u043e\u0441\u0442\u044c \u043e\u0440\u0443\u0436\u0438\u044f"",
                            ""values"": [
                                [
                                    ""9"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 14
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""56"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0421\u0438\u043b\u0430"",
                            ""values"": [
                                [
                                    ""96"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        },
                        {
                            ""name"": ""\u041b\u043e\u0432\u043a"",
                            ""values"": [
                                [
                                    ""96"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""implicitMods"": [
                        ""18% \u043f\u043e\u0432\u044b\u0448\u0435\u043d\u0438\u0435 \u043c\u0435\u0442\u043a\u043e\u0441\u0442\u0438""
                    ],
                    ""explicitMods"": [
                        ""67% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0444\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430"",
                        ""\u0414\u043e\u0431\u0430\u0432\u043b\u044f\u0435\u0442 \u043e\u0442 12 \u0434\u043e 21 \u0444\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430"",
                        ""\u0414\u043e\u0431\u0430\u0432\u043b\u044f\u0435\u0442 \u043e\u0442 5 \u0434\u043e 12 \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u043e\u0433\u043d\u044f"",
                        ""15% \u0441\u043d\u0438\u0436\u0435\u043d\u0438\u0435 \u043f\u043e\u0440\u043e\u0433\u0430 \u043e\u0433\u043b\u0443\u0448\u0435\u043d\u0438\u044f \u0432\u0440\u0430\u0433\u043e\u0432"",
                        ""+5 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f \u0437\u0430 \u043a\u0430\u0436\u0434\u043e\u0433\u043e \u0437\u0430\u0434\u0435\u0442\u043e\u0433\u043e \u0430\u0442\u0430\u043a\u043e\u0439 \u0432\u0440\u0430\u0433\u0430""
                    ],
                    ""frameType"": 2,
                    ""x"": 3,
                    ""y"": 3,
                    ""inventoryId"": ""Stash9"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 0,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/Support\/ChancetoIgnite.png?scale=1&scaleIndex=0&w=1&h=1&v=edeeb9cb97280655b5a3be33a3d3ca573"",
                    ""support"": true,
                    ""league"": ""Hardcore"",
                    ""id"": ""7f10d5d6b0bcae6b6bce079fed83185fba6cf331d786d4fbcd69edf7c08dd1fe"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""\u0428\u0430\u043d\u0441 \u043f\u043e\u0434\u0436\u0435\u0447\u044c"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u041e\u0433\u043e\u043d\u044c, \u041f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0430"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""1"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 5
                        },
                        {
                            ""name"": ""\u041c\u043d\u043e\u0436\u0438\u0442\u0435\u043b\u044c \u043c\u0430\u043d\u044b"",
                            ""values"": [
                                [
                                    ""120%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""additionalProperties"": [
                        {
                            ""name"": ""\u041e\u043f\u044b\u0442"",
                            ""values"": [
                                [
                                    ""1\/3231"",
                                    0
                                ]
                            ],
                            ""displayMode"": 2,
                            ""progress"": 0.000309501716401428
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""8"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0418\u043d\u0442"",
                            ""values"": [
                                [
                                    ""18"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""secDescrText"": ""\u0423\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u0442 \u043b\u044e\u0431\u043e\u0435 \u0443\u043c\u0435\u043d\u0438\u0435, \u043d\u0430\u043d\u043e\u0441\u044f\u0449\u0435\u0435 \u0443\u0434\u0430\u0440\u044b \u043f\u043e \u0432\u0440\u0430\u0433\u0430\u043c."",
                    ""explicitMods"": [
                        ""\u0423\u0441\u0438\u043b\u0435\u043d\u043d\u044b\u0435 \u0443\u043c\u0435\u043d\u0438\u044f \u043d\u0430\u043d\u043e\u0441\u044f\u0442 \u043d\u0430 10% \u0431\u043e\u043b\u044c\u0448\u0435 \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u043e\u0433\u043d\u044f"",
                        ""\u0423\u0441\u0438\u043b\u0435\u043d\u043d\u044b\u0435 \u0443\u043c\u0435\u043d\u0438\u044f \u0438\u043c\u0435\u044e\u0442 30% \u0448\u0430\u043d\u0441 \u043f\u043e\u0434\u0436\u0435\u0447\u044c""
                    ],
                    ""descrText"": ""\u042d\u0442\u043e \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438. \u041e\u043d \u0434\u0430\u0435\u0442 \u043f\u0440\u0435\u0438\u043c\u0443\u0449\u0435\u0441\u0442\u0432\u0430 \u043d\u0435 \u0433\u0435\u0440\u043e\u044e, \u0430 \u043a\u0430\u043c\u043d\u044e \u0443\u043c\u0435\u043d\u0438\u044f \u0432 \u0441\u0432\u044f\u0437\u0430\u043d\u043d\u044b\u0445 \u0433\u043d\u0435\u0437\u0434\u0430\u0445. \u0412\u0441\u0442\u0430\u0432\u044c\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438 \u0432 \u0433\u043d\u0435\u0437\u0434\u043e, \u0441\u043e\u0435\u0434\u0438\u043d\u0435\u043d\u043d\u043e\u0435 \u0441 \u0433\u043d\u0435\u0437\u0434\u043e\u043c \u0443\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u043c\u043e\u0433\u043e \u043a\u0430\u043c\u043d\u044f \u0430\u043a\u0442\u0438\u0432\u043d\u043e\u0433\u043e \u0443\u043c\u0435\u043d\u0438\u044f. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                    ""frameType"": 4,
                    ""x"": 8,
                    ""y"": 5,
                    ""inventoryId"": ""Stash10"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 0,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/Support\/Knockback.png?scale=1&scaleIndex=0&w=1&h=1&v=f4c5ecc35abb51eb0c9254f635f11e2a3"",
                    ""support"": true,
                    ""league"": ""Hardcore"",
                    ""id"": ""acbc01564b2558ea17652f4a99baeef4be67d2085677f7136f587ec117b32d69"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""\u041e\u0442\u0431\u0440\u0430\u0441\u044b\u0432\u0430\u043d\u0438\u0435"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u041f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0430"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""1"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 5
                        }
                    ],
                    ""additionalProperties"": [
                        {
                            ""name"": ""\u041e\u043f\u044b\u0442"",
                            ""values"": [
                                [
                                    ""1\/3231"",
                                    0
                                ]
                            ],
                            ""displayMode"": 2,
                            ""progress"": 0.000309501716401428
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""8"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0421\u0438\u043b\u0430"",
                            ""values"": [
                                [
                                    ""18"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""secDescrText"": ""\u0423\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u0442 \u043b\u044e\u0431\u043e\u0435 \u0443\u043c\u0435\u043d\u0438\u0435, \u043d\u0430\u043d\u043e\u0441\u044f\u0449\u0435\u0435 \u0443\u0434\u0430\u0440\u044b \u043f\u043e \u0432\u0440\u0430\u0433\u0430\u043c."",
                    ""explicitMods"": [
                        ""\u0423\u0441\u0438\u043b\u0435\u043d\u043d\u044b\u0435 \u0443\u043c\u0435\u043d\u0438\u044f \u0438\u043c\u0435\u044e\u0442 25% \u0448\u0430\u043d\u0441 \u043e\u0442\u0431\u0440\u043e\u0441\u0438\u0442\u044c \u0432\u0440\u0430\u0433\u043e\u0432 \u043f\u0440\u0438 \u043d\u0430\u043d\u0435\u0441\u0435\u043d\u0438\u0438 \u0443\u0434\u0430\u0440\u0430"",
                        ""\u0423\u0441\u0438\u043b\u0435\u043d\u043d\u044b\u0435 \u0443\u043c\u0435\u043d\u0438\u044f \u0438\u043c\u0435\u044e\u0442 50% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u044f \u0434\u0438\u0441\u0442\u0430\u043d\u0446\u0438\u0438 \u043e\u0442\u0431\u0440\u0430\u0441\u044b\u0432\u0430\u043d\u0438\u044f""
                    ],
                    ""descrText"": ""\u042d\u0442\u043e \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438. \u041e\u043d \u0434\u0430\u0435\u0442 \u043f\u0440\u0435\u0438\u043c\u0443\u0449\u0435\u0441\u0442\u0432\u0430 \u043d\u0435 \u0433\u0435\u0440\u043e\u044e, \u0430 \u043a\u0430\u043c\u043d\u044e \u0443\u043c\u0435\u043d\u0438\u044f \u0432 \u0441\u0432\u044f\u0437\u0430\u043d\u043d\u044b\u0445 \u0433\u043d\u0435\u0437\u0434\u0430\u0445. \u0412\u0441\u0442\u0430\u0432\u044c\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438 \u0432 \u0433\u043d\u0435\u0437\u0434\u043e, \u0441\u043e\u0435\u0434\u0438\u043d\u0435\u043d\u043d\u043e\u0435 \u0441 \u0433\u043d\u0435\u0437\u0434\u043e\u043c \u0443\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u043c\u043e\u0433\u043e \u043a\u0430\u043c\u043d\u044f \u0430\u043a\u0442\u0438\u0432\u043d\u043e\u0433\u043e \u0443\u043c\u0435\u043d\u0438\u044f. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                    ""frameType"": 4,
                    ""x"": 9,
                    ""y"": 6,
                    ""inventoryId"": ""Stash11"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 2,
                    ""h"": 3,
                    ""ilvl"": 68,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Weapons\/OneHandWeapons\/OneHandSwords\/OneHandSword8.png?scale=1&scaleIndex=0&w=2&h=3&v=c134bf2ee29330334f8b71f4cc992f133"",
                    ""league"": ""Hardcore"",
                    ""id"": ""63394d9c0f47eb3452935a68c93a07330b1b08e51f628d985549f62dad529f24"",
                    ""sockets"": [
                        {
                            ""group"": 0,
                            ""attr"": ""D""
                        },
                        {
                            ""group"": 0,
                            ""attr"": ""S""
                        }
                    ],
                    ""name"": ""<<set:MS>><<set:M>><<set:S>><if:MS>{\u041e\u0440\u043b\u0438\u043d\u044b\u0439
                    }<elif:FS>{\u041e\u0440\u043b\u0438\u043d\u0430\u044f
                    }<elif:NS>{\u041e\u0440\u043b\u0438\u043d\u043e\u0435
                    }<elif:MP>{\u041e\u0440\u043b\u0438\u043d\u044b\u0435
                    }<elif:FP>{\u041e\u0440\u043b\u0438\u043d\u044b\u0435
                    }<elif:NP>{\u041e\u0440\u043b\u0438\u043d\u044b\u0435
                    } \u0440\u0430\u0441\u0441\u0435\u043a\u0430\u0442\u0435\u043b\u044c"",
                    ""typeLine"": ""\u0421\u0443\u043c\u0440\u0430\u0447\u043d\u044b\u0439 \u043a\u043b\u0438\u043d\u043e\u043a"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u041e\u0434\u043d\u043e\u0440\u0443\u0447\u043d\u044b\u0439 \u043c\u0435\u0447"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0424\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u0438\u0439 \u0443\u0440\u043e\u043d"",
                            ""values"": [
                                [
                                    ""95-244"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 9
                        },
                        {
                            ""name"": ""\u0428\u0430\u043d\u0441 \u043a\u0440\u0438\u0442\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0434\u0430\u0440\u0430"",
                            ""values"": [
                                [
                                    ""6.50%"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 12
                        },
                        {
                            ""name"": ""\u0410\u0442\u0430\u043a \u0432 \u0441\u0435\u043a\u0443\u043d\u0434\u0443"",
                            ""values"": [
                                [
                                    ""1.30"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 13
                        },
                        {
                            ""name"": ""\u0414\u0430\u043b\u044c\u043d\u043e\u0441\u0442\u044c \u043e\u0440\u0443\u0436\u0438\u044f"",
                            ""values"": [
                                [
                                    ""9"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 14
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""53"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0421\u0438\u043b\u0430"",
                            ""values"": [
                                [
                                    ""91"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        },
                        {
                            ""name"": ""\u041b\u043e\u0432\u043a"",
                            ""values"": [
                                [
                                    ""91"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""implicitMods"": [
                        ""18% \u043f\u043e\u0432\u044b\u0448\u0435\u043d\u0438\u0435 \u043c\u0435\u0442\u043a\u043e\u0441\u0442\u0438""
                    ],
                    ""explicitMods"": [
                        ""+1 \u043a \u0443\u0440\u043e\u0432\u043d\u044e \u0440\u0430\u0437\u043c\u0435\u0449\u0451\u043d\u043d\u044b\u0445 \u043a\u0430\u043c\u043d\u0435\u0439 \u0431\u043b\u0438\u0436\u043d\u0435\u0433\u043e \u0431\u043e\u044f"",
                        ""102% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0444\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430"",
                        ""\u0414\u043e\u0431\u0430\u0432\u043b\u044f\u0435\u0442 \u043e\u0442 17 \u0434\u043e 35 \u0444\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430"",
                        ""+22 \u043a \u0441\u0438\u043b\u0435"",
                        ""30% \u043f\u043e\u0432\u044b\u0448\u0435\u043d\u0438\u0435 \u0448\u0430\u043d\u0441\u0430 \u043a\u0440\u0438\u0442\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0434\u0430\u0440\u0430"",
                        ""+21% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u043c\u043e\u043b\u043d\u0438\u0438""
                    ],
                    ""frameType"": 2,
                    ""x"": 10,
                    ""y"": 9,
                    ""inventoryId"": ""Stash12"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 0,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/Hatred.png?scale=1&scaleIndex=0&w=1&h=1&v=37205cdc1ceb1f70b66d9ca6b6e7ad4c3"",
                    ""support"": false,
                    ""league"": ""Hardcore"",
                    ""id"": ""ea7d8a61722ff4cf7aea595d31623de7d8d83d0f187de273d62be6b6bca0041d"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""\u0425\u043e\u043b\u043e\u0434\u043d\u0430\u044f \u043d\u0435\u043d\u0430\u0432\u0438\u0441\u0442\u044c"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0410\u0443\u0440\u0430, \u0427\u0430\u0440\u044b, \u041e\u0431\u043b\u0430\u0441\u0442\u044c, \u0425\u043e\u043b\u043e\u0434"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""1"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 5
                        },
                        {
                            ""name"": ""\u0423\u0434\u0435\u0440\u0436\u0430\u043d\u043e \u043c\u0430\u043d\u044b"",
                            ""values"": [
                                [
                                    ""50%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041f\u0435\u0440\u0435\u0437\u0430\u0440\u044f\u0434\u043a\u0430"",
                            ""values"": [
                                [
                                    ""1.20 \u0441\u0435\u043a."",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0412\u0440\u0435\u043c\u044f \u043f\u0440\u0438\u043c\u0435\u043d\u0435\u043d\u0438\u044f"",
                            ""values"": [
                                [
                                    ""1.20 \u0441\u0435\u043a."",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""additionalProperties"": [
                        {
                            ""name"": ""\u041e\u043f\u044b\u0442"",
                            ""values"": [
                                [
                                    ""1\/118383"",
                                    0
                                ]
                            ],
                            ""displayMode"": 2,
                            ""progress"": 8.447158506896812e-6
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""24"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041b\u043e\u0432\u043a"",
                            ""values"": [
                                [
                                    ""37"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        },
                        {
                            ""name"": ""\u0418\u043d\u0442"",
                            ""values"": [
                                [
                                    ""25"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""secDescrText"": ""\u0413\u0435\u0440\u043e\u0439 \u043e\u043a\u0440\u0443\u0436\u0430\u0435\u0442 \u0441\u0435\u0431\u044f \u0430\u0443\u0440\u043e\u0439, \u043a\u043e\u0442\u043e\u0440\u0430\u044f \u0434\u043e\u0431\u0430\u0432\u043b\u044f\u0435\u0442 \u043a \u0430\u0442\u0430\u043a\u0430\u043c \u0443\u0440\u043e\u043d \u043e\u0442 \u0445\u043e\u043b\u043e\u0434\u0430. \u0410\u0443\u0440\u0430 \u0434\u0435\u0439\u0441\u0442\u0432\u0443\u0435\u0442 \u043a\u0430\u043a \u043d\u0430 \u0433\u0435\u0440\u043e\u044f, \u0442\u0430\u043a \u0438 \u043d\u0430 \u0435\u0433\u043e \u0441\u043e\u044e\u0437\u043d\u0438\u043a\u043e\u0432."",
                    ""explicitMods"": [
                        ""\u0412\u044b \u0438 \u0431\u043b\u0438\u0436\u0430\u0439\u0448\u0438\u0435 \u0441\u043e\u044e\u0437\u043d\u0438\u043a\u0438 \u043f\u043e\u043b\u0443\u0447\u0430\u0435\u0442\u0435 26% \u0444\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430 \u0432 \u0432\u0438\u0434\u0435 \u0434\u043e\u043f\u043e\u043b\u043d\u0438\u0442\u0435\u043b\u044c\u043d\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u0445\u043e\u043b\u043e\u0434\u0430""
                    ],
                    ""descrText"": ""\u0414\u043b\u044f \u043f\u043e\u043b\u0443\u0447\u0435\u043d\u0438\u044f \u0443\u043c\u0435\u043d\u0438\u044f \u0432\u044b\u0431\u0435\u0440\u0438\u0442\u0435 \u043f\u0440\u0435\u0434\u043c\u0435\u0442 \u0438 \u043f\u043e\u043c\u0435\u0441\u0442\u0438\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u0432 \u0433\u043d\u0435\u0437\u0434\u043e \u0441\u043e\u043e\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0443\u044e\u0449\u0435\u0433\u043e \u0446\u0432\u0435\u0442\u0430. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                    ""frameType"": 4,
                    ""x"": 6,
                    ""y"": 5,
                    ""inventoryId"": ""Stash13"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 0,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/DecoyTotem.png?scale=1&scaleIndex=0&w=1&h=1&v=5d88e661c175a75fd118bda4e06e7d3a3"",
                    ""support"": false,
                    ""league"": ""Hardcore"",
                    ""id"": ""6669c00610cdda20492a3f91156858cd562c4a6308724a6dc90f6b70726d2458"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""\u0422\u043e\u0442\u0435\u043c-\u043f\u0440\u0438\u043c\u0430\u043d\u043a\u0430"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0422\u043e\u0442\u0435\u043c, \u0427\u0430\u0440\u044b, \u0414\u043b\u0438\u0442\u0441\u044f, \u041e\u0431\u043b\u0430\u0441\u0442\u044c"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""1"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 5
                        },
                        {
                            ""name"": ""\u0420\u0430\u0441\u0445\u043e\u0434 \u043c\u0430\u043d\u044b"",
                            ""values"": [
                                [
                                    ""9"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041f\u0435\u0440\u0435\u0437\u0430\u0440\u044f\u0434\u043a\u0430"",
                            ""values"": [
                                [
                                    ""4.00 \u0441\u0435\u043a."",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0412\u0440\u0435\u043c\u044f \u043f\u0440\u0438\u043c\u0435\u043d\u0435\u043d\u0438\u044f"",
                            ""values"": [
                                [
                                    ""1.00 \u0441\u0435\u043a."",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041a\u0430\u0447\u0435\u0441\u0442\u0432\u043e"",
                            ""values"": [
                                [
                                    ""+11%"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 6
                        }
                    ],
                    ""additionalProperties"": [
                        {
                            ""name"": ""\u041e\u043f\u044b\u0442"",
                            ""values"": [
                                [
                                    ""1\/841"",
                                    0
                                ]
                            ],
                            ""displayMode"": 2,
                            ""progress"": 0.0011890606256201863
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""4"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0421\u0438\u043b\u0430"",
                            ""values"": [
                                [
                                    ""16"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""secDescrText"": ""\u0413\u0435\u0440\u043e\u0439 \u0443\u0441\u0442\u0430\u043d\u0430\u0432\u043b\u0438\u0432\u0430\u0435\u0442  \u0442\u043e\u0442\u0435\u043c, \u043a\u043e\u0442\u043e\u0440\u044b\u0439 \u0432\u044b\u043d\u0443\u0436\u0434\u0435\u043d\u044b \u0430\u0442\u0430\u043a\u043e\u0432\u0430\u0442\u044c \u043e\u043a\u0430\u0437\u0430\u0432\u0448\u0438\u0435\u0441\u044f \u0440\u044f\u0434\u043e\u043c \u0432\u0440\u0430\u0433\u0438."",
                    ""explicitMods"": [
                        ""\u0412\u0440\u0435\u043c\u044f \u0441\u0443\u0449\u0435\u0441\u0442\u0432\u043e\u0432\u0430\u043d\u0438\u044f \u0442\u043e\u0442\u0435\u043c\u0430 8 \u0441\u0435\u043a\u0443\u043d\u0434(-\u044b)"",
                        ""\u0423\u0441\u0442\u0430\u043d\u0430\u0432\u043b\u0438\u0432\u0430\u0435\u0442 \u0442\u043e\u0442\u0435\u043c, \u0438\u0441\u043f\u043e\u043b\u044c\u0437\u0443\u044e\u0449\u0438\u0439 \u044d\u0442\u043e \u0443\u043c\u0435\u043d\u0438\u0435"",
                        ""\u0422\u043e\u0442\u0435\u043c\u044b, \u0441\u043e\u0437\u0434\u0430\u043d\u043d\u044b\u0435 \u044d\u0442\u0438\u043c \u0443\u043c\u0435\u043d\u0438\u0435\u043c, \u043d\u0435 \u043c\u043e\u0433\u0443\u0442 \u0443\u043a\u043b\u043e\u043d\u044f\u0442\u044c\u0441\u044f"",
                        ""11% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f \u0442\u043e\u0442\u0435\u043c\u0430""
                    ],
                    ""descrText"": ""\u0414\u043b\u044f \u043f\u043e\u043b\u0443\u0447\u0435\u043d\u0438\u044f \u0443\u043c\u0435\u043d\u0438\u044f \u0432\u044b\u0431\u0435\u0440\u0438\u0442\u0435 \u043f\u0440\u0435\u0434\u043c\u0435\u0442 \u0438 \u043f\u043e\u043c\u0435\u0441\u0442\u0438\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u0432 \u0433\u043d\u0435\u0437\u0434\u043e \u0441\u043e\u043e\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0443\u044e\u0449\u0435\u0433\u043e \u0446\u0432\u0435\u0442\u0430. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                    ""frameType"": 4,
                    ""x"": 9,
                    ""y"": 3,
                    ""inventoryId"": ""Stash14"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 2,
                    ""h"": 2,
                    ""ilvl"": 70,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Armours\/Gloves\/GlovesStr4.png?scale=1&scaleIndex=0&w=2&h=2&v=b2997b2df11d3b19cbb6a4c3054acda63"",
                    ""league"": ""Hardcore"",
                    ""id"": ""12b27dd4bc645f762160afe74fccb6f7a0b19e53fb0bf8f69cff6290fd7d3478"",
                    ""sockets"": [
                        {
                            ""group"": 0,
                            ""attr"": ""S""
                        },
                        {
                            ""group"": 0,
                            ""attr"": ""S""
                        }
                    ],
                    ""name"": ""<<set:FP>><<set:F>><<set:P>><if:MS>{\u0423\u043d\u044b\u043b\u044b\u0439
                    }<elif:FS>{\u0423\u043d\u044b\u043b\u0430\u044f
                    }<elif:NS>{\u0423\u043d\u044b\u043b\u043e\u0435
                    }<elif:MP>{\u0423\u043d\u044b\u043b\u044b\u0435
                    }<elif:FP>{\u0423\u043d\u044b\u043b\u044b\u0435
                    }<elif:NP>{\u0423\u043d\u044b\u043b\u044b\u0435
                    } \u043f\u043e\u0434\u043a\u043b\u0430\u0434\u043a\u0438"",
                    ""typeLine"": ""\u041f\u0435\u0440\u0447\u0430\u0442\u043a\u0438 \u0433\u0438\u0433\u0430\u043d\u0442\u0430"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""note"": ""~b\/o 1 chaos"",
                    ""properties"": [
                        {
                            ""name"": ""\u0411\u0440\u043e\u043d\u044f"",
                            ""values"": [
                                [
                                    ""174"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 16
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""53"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0421\u0438\u043b\u0430"",
                            ""values"": [
                                [
                                    ""76"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""explicitMods"": [
                        ""+14 \u043a \u0441\u0438\u043b\u0435"",
                        ""+29 \u043a \u043c\u0430\u043a\u0441\u0438\u043c\u0443\u043c\u0443 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f"",
                        ""+20% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u0445\u043e\u043b\u043e\u0434\u0443"",
                        ""+28% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u043c\u043e\u043b\u043d\u0438\u0438""
                    ],
                    ""frameType"": 2,
                    ""x"": 4,
                    ""y"": 10,
                    ""inventoryId"": ""Stash15"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 0,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/ColdResistAura.png?scale=1&scaleIndex=0&w=1&h=1&v=ff20ad8bc6877c4ffbf2606e812f3d7e3"",
                    ""support"": false,
                    ""league"": ""Hardcore"",
                    ""id"": ""f6fd44f8fe47abcfd62a337cb8f81586a2f3309c6deff30b13b8fb583ee56687"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""\u0421\u043f\u0430\u0441\u0435\u043d\u0438\u0435 \u043e\u0442 \u0445\u043e\u043b\u043e\u0434\u0430"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0410\u0443\u0440\u0430, \u0427\u0430\u0440\u044b, \u041e\u0431\u043b\u0430\u0441\u0442\u044c, \u0425\u043e\u043b\u043e\u0434"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""16"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 5
                        },
                        {
                            ""name"": ""\u0423\u0434\u0435\u0440\u0436\u0430\u043d\u043e \u043c\u0430\u043d\u044b"",
                            ""values"": [
                                [
                                    ""35%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041f\u0435\u0440\u0435\u0437\u0430\u0440\u044f\u0434\u043a\u0430"",
                            ""values"": [
                                [
                                    ""1.20 \u0441\u0435\u043a."",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0412\u0440\u0435\u043c\u044f \u043f\u0440\u0438\u043c\u0435\u043d\u0435\u043d\u0438\u044f"",
                            ""values"": [
                                [
                                    ""1.20 \u0441\u0435\u043a."",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""additionalProperties"": [
                        {
                            ""name"": ""\u041e\u043f\u044b\u0442"",
                            ""values"": [
                                [
                                    ""13413371\/15206031"",
                                    0
                                ]
                            ],
                            ""displayMode"": 2,
                            ""progress"": 0.8821086287498474
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""62"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041b\u043e\u0432\u043a"",
                            ""values"": [
                                [
                                    ""87"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        },
                        {
                            ""name"": ""\u0418\u043d\u0442"",
                            ""values"": [
                                [
                                    ""60"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""secDescrText"": ""\u0413\u0435\u0440\u043e\u0439 \u043e\u043a\u0440\u0443\u0436\u0430\u0435\u0442 \u0441\u0435\u0431\u044f \u0430\u0443\u0440\u043e\u0439, \u043a\u043e\u0442\u043e\u0440\u0430\u044f \u043f\u043e\u0432\u044b\u0448\u0430\u0435\u0442 \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u0435 \u0445\u043e\u043b\u043e\u0434\u0443. \u0410\u0443\u0440\u0430 \u0434\u0435\u0439\u0441\u0442\u0432\u0443\u0435\u0442 \u043a\u0430\u043a \u043d\u0430 \u0433\u0435\u0440\u043e\u044f, \u0442\u0430\u043a \u0438 \u043d\u0430 \u0435\u0433\u043e \u0441\u043e\u044e\u0437\u043d\u0438\u043a\u043e\u0432."",
                    ""explicitMods"": [
                        ""+15 \u043a \u0440\u0430\u0434\u0438\u0443\u0441\u0443"",
                        ""\u0412\u044b \u0438 \u0431\u043b\u0438\u0436\u0430\u0439\u0448\u0438\u0435 \u0441\u043e\u044e\u0437\u043d\u0438\u043a\u0438 \u043f\u043e\u043b\u0443\u0447\u0430\u0435\u0442\u0435 37% \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044f \u0445\u043e\u043b\u043e\u0434\u0443"",
                        ""\u0412\u044b \u0438 \u0431\u043b\u0438\u0436\u0430\u0439\u0448\u0438\u0435 \u0441\u043e\u044e\u0437\u043d\u0438\u043a\u0438 \u043f\u043e\u043b\u0443\u0447\u0430\u0435\u0442\u0435 2% \u043a \u043c\u0430\u043a\u0441\u0438\u043c\u0430\u043b\u044c\u043d\u043e\u043c\u0443 \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u0445\u043e\u043b\u043e\u0434\u0443""
                    ],
                    ""descrText"": ""\u0414\u043b\u044f \u043f\u043e\u043b\u0443\u0447\u0435\u043d\u0438\u044f \u0443\u043c\u0435\u043d\u0438\u044f \u0432\u044b\u0431\u0435\u0440\u0438\u0442\u0435 \u043f\u0440\u0435\u0434\u043c\u0435\u0442 \u0438 \u043f\u043e\u043c\u0435\u0441\u0442\u0438\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u0432 \u0433\u043d\u0435\u0437\u0434\u043e \u0441\u043e\u043e\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0443\u044e\u0449\u0435\u0433\u043e \u0446\u0432\u0435\u0442\u0430. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                    ""frameType"": 4,
                    ""x"": 9,
                    ""y"": 4,
                    ""inventoryId"": ""Stash16"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 2,
                    ""h"": 3,
                    ""ilvl"": 63,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Armours\/BodyArmours\/BodyDex3B.png?scale=1&scaleIndex=0&w=2&h=3&v=808fa9360bda3074d55dce26cc0e823e3"",
                    ""league"": ""Hardcore"",
                    ""id"": ""3c808bfae817a380fd9338cc15b3a77c2e1a1c214b86795c87eafb67a897b859"",
                    ""sockets"": [
                        {
                            ""group"": 0,
                            ""attr"": ""D""
                        },
                        {
                            ""group"": 0,
                            ""attr"": ""D""
                        },
                        {
                            ""group"": 0,
                            ""attr"": ""D""
                        }
                    ],
                    ""name"": ""<<set:FS>><<set:F>><<set:S>><if:MS>{\u0414\u0440\u0430\u043a\u043e\u043d\u0438\u0439
                    }<elif:FS>{\u0414\u0440\u0430\u043a\u043e\u043d\u044c\u044f
                    }<elif:NS>{\u0414\u0440\u0430\u043a\u043e\u043d\u044c\u0435
                    }<elif:MP>{\u0414\u0440\u0430\u043a\u043e\u043d\u044c\u0438
                    }<elif:FP>{\u0414\u0440\u0430\u043a\u043e\u043d\u044c\u0438
                    }<elif:NP>{\u0414\u0440\u0430\u043a\u043e\u043d\u044c\u0438
                    } \u0448\u043a\u0443\u0440\u0430"",
                    ""typeLine"": ""\u041a\u043e\u0436\u0430\u043d\u043a\u0430 \u043f\u0440\u0438\u0437\u0432\u0430\u043d\u0438\u044f"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0423\u043a\u043b\u043e\u043d\u0435\u043d\u0438\u0435"",
                            ""values"": [
                                [
                                    ""883"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 17
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""59"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041b\u043e\u0432\u043a"",
                            ""values"": [
                                [
                                    ""160"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""explicitMods"": [
                        ""47% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0443\u043a\u043b\u043e\u043d\u0435\u043d\u0438\u044f"",
                        ""+28 \u043a \u043c\u0430\u043a\u0441\u0438\u043c\u0443\u043c\u0443 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f"",
                        ""+31% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u043e\u0433\u043d\u044e"",
                        ""+30% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u043c\u043e\u043b\u043d\u0438\u0438""
                    ],
                    ""frameType"": 2,
                    ""x"": 10,
                    ""y"": 3,
                    ""inventoryId"": ""Stash17"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 2,
                    ""h"": 3,
                    ""ilvl"": 69,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Armours\/BodyArmours\/BodyDex1B.png?scale=1&scaleIndex=0&w=2&h=3&v=6c54a5109d16d454488c1d342c00154e3"",
                    ""league"": ""Hardcore"",
                    ""id"": ""e24ef7039cc2a5e07e736e0bb85808e895cf02effe5d64f8dcdea72477dbc518"",
                    ""sockets"": [
                        {
                            ""group"": 0,
                            ""attr"": ""D""
                        },
                        {
                            ""group"": 0,
                            ""attr"": ""D""
                        },
                        {
                            ""group"": 1,
                            ""attr"": ""D""
                        }
                    ],
                    ""name"": ""<<set:MS>><<set:M>><<set:S>><if:MS>{\u0414\u0443\u0445\u043e\u0432\u043d\u044b\u0439
                    }<elif:FS>{\u0414\u0443\u0445\u043e\u0432\u043d\u0430\u044f
                    }<elif:NS>{\u0414\u0443\u0445\u043e\u0432\u043d\u043e\u0435
                    }<elif:MP>{\u0414\u0443\u0445\u043e\u0432\u043d\u044b\u0435
                    }<elif:FP>{\u0414\u0443\u0445\u043e\u0432\u043d\u044b\u0435
                    }<elif:NP>{\u0414\u0443\u0445\u043e\u0432\u043d\u044b\u0435
                    } \u0441\u0442\u0440\u0430\u0436\u043d\u0438\u043a"",
                    ""typeLine"": ""\u0410\u043a\u0443\u043b\u0438\u0439 \u043f\u043e\u043b\u0443\u043a\u0430\u0444\u0442\u0430\u043d"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0423\u043a\u043b\u043e\u043d\u0435\u043d\u0438\u0435"",
                            ""values"": [
                                [
                                    ""559"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 17
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""56"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041b\u043e\u0432\u043a"",
                            ""values"": [
                                [
                                    ""152"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""explicitMods"": [
                        ""+79 \u043a \u043c\u0430\u043a\u0441\u0438\u043c\u0443\u043c\u0443 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f"",
                        ""+25% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u043e\u0433\u043d\u044e"",
                        ""+29% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u0445\u043e\u043b\u043e\u0434\u0443"",
                        ""+25% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u043c\u043e\u043b\u043d\u0438\u0438""
                    ],
                    ""frameType"": 2,
                    ""x"": 10,
                    ""y"": 0,
                    ""inventoryId"": ""Stash18"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 0,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/Support\/ColdtoFire.png?scale=1&scaleIndex=0&w=1&h=1&v=f76fd6c513a3bfd76834138f850681133"",
                    ""support"": true,
                    ""league"": ""Hardcore"",
                    ""id"": ""3ed0f55369906e89f9016fbda348a5852231abef0c4dab4944c953f136cfbc56"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""\u0425\u043e\u043b\u043e\u0434 \u0432 \u043e\u0433\u043e\u043d\u044c"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0425\u043e\u043b\u043e\u0434, \u041e\u0433\u043e\u043d\u044c, \u041f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0430"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""17"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 5
                        },
                        {
                            ""name"": ""\u041c\u043d\u043e\u0436\u0438\u0442\u0435\u043b\u044c \u043c\u0430\u043d\u044b"",
                            ""values"": [
                                [
                                    ""110%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""additionalProperties"": [
                        {
                            ""name"": ""\u041e\u043f\u044b\u0442"",
                            ""values"": [
                                [
                                    ""13585984\/26260555"",
                                    0
                                ]
                            ],
                            ""displayMode"": 2,
                            ""progress"": 0.5173532366752625
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""64"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0421\u0438\u043b\u0430"",
                            ""values"": [
                                [
                                    ""64"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        },
                        {
                            ""name"": ""\u0418\u043d\u0442"",
                            ""values"": [
                                [
                                    ""44"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""secDescrText"": ""\u0423\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u0442 \u043b\u044e\u0431\u043e\u0435 \u0443\u043c\u0435\u043d\u0438\u0435, \u043d\u0430\u043d\u043e\u0441\u044f\u0449\u0435\u0435 \u0443\u0434\u0430\u0440\u044b \u043f\u043e \u0432\u0440\u0430\u0433\u0430\u043c."",
                    ""explicitMods"": [
                        ""\u0423\u0441\u0438\u043b\u0435\u043d\u043d\u044b\u0435 \u0443\u043c\u0435\u043d\u0438\u044f \u0434\u0430\u0440\u0443\u044e\u0442 26% \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u0445\u043e\u043b\u043e\u0434\u0430 \u0432 \u0432\u0438\u0434\u0435 \u0434\u043e\u043f\u043e\u043b\u043d\u0438\u0442\u0435\u043b\u044c\u043d\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u043e\u0433\u043d\u044f"",
                        ""50% \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u0445\u043e\u043b\u043e\u0434\u0430 \u0443\u0441\u0438\u043b\u0435\u043d\u043d\u044b\u0445 \u0443\u043c\u0435\u043d\u0438\u0439 \u0441\u0442\u0430\u043d\u043e\u0432\u0438\u0442\u0441\u044f \u0443\u0440\u043e\u043d\u043e\u043c \u043e\u0442 \u043e\u0433\u043d\u044f""
                    ],
                    ""descrText"": ""\u042d\u0442\u043e \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438. \u041e\u043d \u0434\u0430\u0435\u0442 \u043f\u0440\u0435\u0438\u043c\u0443\u0449\u0435\u0441\u0442\u0432\u0430 \u043d\u0435 \u0433\u0435\u0440\u043e\u044e, \u0430 \u043a\u0430\u043c\u043d\u044e \u0443\u043c\u0435\u043d\u0438\u044f \u0432 \u0441\u0432\u044f\u0437\u0430\u043d\u043d\u044b\u0445 \u0433\u043d\u0435\u0437\u0434\u0430\u0445. \u0412\u0441\u0442\u0430\u0432\u044c\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438 \u0432 \u0433\u043d\u0435\u0437\u0434\u043e, \u0441\u043e\u0435\u0434\u0438\u043d\u0435\u043d\u043d\u043e\u0435 \u0441 \u0433\u043d\u0435\u0437\u0434\u043e\u043c \u0443\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u043c\u043e\u0433\u043e \u043a\u0430\u043c\u043d\u044f \u0430\u043a\u0442\u0438\u0432\u043d\u043e\u0433\u043e \u0443\u043c\u0435\u043d\u0438\u044f. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                    ""frameType"": 4,
                    ""x"": 4,
                    ""y"": 1,
                    ""inventoryId"": ""Stash19"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 2,
                    ""h"": 2,
                    ""ilvl"": 68,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Armours\/Boots\/BootsDexInt4.png?scale=1&scaleIndex=0&w=2&h=2&v=bfbd6b83d1a5a8dafbae030a0041b5fe3"",
                    ""league"": ""Hardcore"",
                    ""id"": ""4bccf7e2739563d35a04e0d3ba40283df5f33313645f26fbb49df1495af564a6"",
                    ""sockets"": [
                        {
                            ""group"": 0,
                            ""attr"": ""D""
                        }
                    ],
                    ""name"": ""<<set:FS>><<set:F>><<set:S>><if:MS>{\u0412\u0435\u0440\u0445\u043e\u0432\u043d\u044b\u0439
                    }<elif:FS>{\u0412\u0435\u0440\u0445\u043e\u0432\u043d\u0430\u044f
                    }<elif:NS>{\u0412\u0435\u0440\u0445\u043e\u0432\u043d\u043e\u0435
                    }<elif:MP>{\u0412\u0435\u0440\u0445\u043e\u0432\u043d\u044b\u0435
                    }<elif:FP>{\u0412\u0435\u0440\u0445\u043e\u0432\u043d\u044b\u0435
                    }<elif:NP>{\u0412\u0435\u0440\u0445\u043e\u0432\u043d\u044b\u0435
                    } \u043f\u043e\u0441\u0442\u0443\u043f\u044c"",
                    ""typeLine"": ""\u0421\u0430\u043f\u043e\u0433\u0438 \u043a\u0440\u043e\u0432\u0438"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0423\u043a\u043b\u043e\u043d\u0435\u043d\u0438\u0435"",
                            ""values"": [
                                [
                                    ""109"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 17
                        },
                        {
                            ""name"": ""\u042d\u043d\u0435\u0440\u0433\u0435\u0442\u0438\u0447\u0435\u0441\u043a\u0438\u0439 \u0449\u0438\u0442"",
                            ""values"": [
                                [
                                    ""21"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 18
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""55"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041b\u043e\u0432\u043a"",
                            ""values"": [
                                [
                                    ""52"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        },
                        {
                            ""name"": ""\u0418\u043d\u0442"",
                            ""values"": [
                                [
                                    ""52"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""explicitMods"": [
                        ""10% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0443\u043a\u043b\u043e\u043d\u0435\u043d\u0438\u044f \u0438 \u044d\u043d\u0435\u0440\u0433\u0435\u0442\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0449\u0438\u0442\u0430"",
                        ""+75 \u043a \u043c\u0430\u043a\u0441\u0438\u043c\u0443\u043c\u0443 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f"",
                        ""+30% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u043e\u0433\u043d\u044e"",
                        ""20% \u043f\u043e\u0432\u044b\u0448\u0435\u043d\u0438\u0435 \u0441\u043a\u043e\u0440\u043e\u0441\u0442\u0438 \u043f\u0435\u0440\u0435\u0434\u0432\u0438\u0436\u0435\u043d\u0438\u044f"",
                        ""6% \u0443\u0441\u043a\u043e\u0440\u0435\u043d\u0438\u0435 \u0432\u043e\u0441\u0441\u0442\u0430\u043d\u043e\u0432\u043b\u0435\u043d\u0438\u044f \u043f\u043e\u0441\u043b\u0435 \u043e\u0433\u043b\u0443\u0448\u0435\u043d\u0438\u044f""
                    ],
                    ""frameType"": 2,
                    ""x"": 8,
                    ""y"": 10,
                    ""inventoryId"": ""Stash20"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 0,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/Support\/AddedColdDamage.png?scale=1&scaleIndex=0&w=1&h=1&v=615cfc959458a6613cfa9788e1adedbc3"",
                    ""support"": true,
                    ""league"": ""Hardcore"",
                    ""id"": ""dda4620d0c1788be9fbefbd6d84df65057e609fe8d60920861485d5b864379b3"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""\u0423\u0440\u043e\u043d \u0445\u043e\u043b\u043e\u0434\u043e\u043c"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0425\u043e\u043b\u043e\u0434, \u041f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0430"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""1"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 5
                        },
                        {
                            ""name"": ""\u041c\u043d\u043e\u0436\u0438\u0442\u0435\u043b\u044c \u043c\u0430\u043d\u044b"",
                            ""values"": [
                                [
                                    ""130%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""additionalProperties"": [
                        {
                            ""name"": ""\u041e\u043f\u044b\u0442"",
                            ""values"": [
                                [
                                    ""1\/3231"",
                                    0
                                ]
                            ],
                            ""displayMode"": 2,
                            ""progress"": 0.000309501716401428
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""8"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041b\u043e\u0432\u043a"",
                            ""values"": [
                                [
                                    ""18"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""secDescrText"": ""\u0423\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u0442 \u043b\u044e\u0431\u043e\u0435 \u0443\u043c\u0435\u043d\u0438\u0435, \u043d\u0430\u043d\u043e\u0441\u044f\u0449\u0435\u0435 \u0443\u0434\u0430\u0440\u044b \u043f\u043e \u0432\u0440\u0430\u0433\u0430\u043c."",
                    ""explicitMods"": [
                        ""\u0423\u0441\u0438\u043b\u0435\u043d\u043d\u044b\u0435 \u0443\u043c\u0435\u043d\u0438\u044f \u0438\u043c\u0435\u044e\u0442 \u043e\u0442 4 \u0434\u043e 6 \u0434\u043e\u0431\u0430\u0432\u043b\u0435\u043d\u043d\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u0445\u043e\u043b\u043e\u0434\u0430""
                    ],
                    ""descrText"": ""\u042d\u0442\u043e \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438. \u041e\u043d \u0434\u0430\u0435\u0442 \u043f\u0440\u0435\u0438\u043c\u0443\u0449\u0435\u0441\u0442\u0432\u0430 \u043d\u0435 \u0433\u0435\u0440\u043e\u044e, \u0430 \u043a\u0430\u043c\u043d\u044e \u0443\u043c\u0435\u043d\u0438\u044f \u0432 \u0441\u0432\u044f\u0437\u0430\u043d\u043d\u044b\u0445 \u0433\u043d\u0435\u0437\u0434\u0430\u0445. \u0412\u0441\u0442\u0430\u0432\u044c\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438 \u0432 \u0433\u043d\u0435\u0437\u0434\u043e, \u0441\u043e\u0435\u0434\u0438\u043d\u0435\u043d\u043d\u043e\u0435 \u0441 \u0433\u043d\u0435\u0437\u0434\u043e\u043c \u0443\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u043c\u043e\u0433\u043e \u043a\u0430\u043c\u043d\u044f \u0430\u043a\u0442\u0438\u0432\u043d\u043e\u0433\u043e \u0443\u043c\u0435\u043d\u0438\u044f. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                    ""frameType"": 4,
                    ""x"": 5,
                    ""y"": 2,
                    ""inventoryId"": ""Stash21"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 1,
                    ""h"": 1,
                    ""ilvl"": 0,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/Support\/ColdtoFire.png?scale=1&scaleIndex=0&w=1&h=1&v=f76fd6c513a3bfd76834138f850681133"",
                    ""support"": true,
                    ""league"": ""Hardcore"",
                    ""id"": ""e4b504f337bc9179c0e36f29a6a51164c1044f530b4ebd4246269caa5cf6ba51"",
                    ""sockets"": [
                        
                    ],
                    ""name"": """",
                    ""typeLine"": ""\u0425\u043e\u043b\u043e\u0434 \u0432 \u043e\u0433\u043e\u043d\u044c"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0425\u043e\u043b\u043e\u0434, \u041e\u0433\u043e\u043d\u044c, \u041f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0430"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""1"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 5
                        },
                        {
                            ""name"": ""\u041c\u043d\u043e\u0436\u0438\u0442\u0435\u043b\u044c \u043c\u0430\u043d\u044b"",
                            ""values"": [
                                [
                                    ""110%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        }
                    ],
                    ""additionalProperties"": [
                        {
                            ""name"": ""\u041e\u043f\u044b\u0442"",
                            ""values"": [
                                [
                                    ""1\/69833"",
                                    0
                                ]
                            ],
                            ""displayMode"": 2,
                            ""progress"": 1.4319877664092928e-5
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""18"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0421\u0438\u043b\u0430"",
                            ""values"": [
                                [
                                    ""21"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        },
                        {
                            ""name"": ""\u0418\u043d\u0442"",
                            ""values"": [
                                [
                                    ""14"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""secDescrText"": ""\u0423\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u0442 \u043b\u044e\u0431\u043e\u0435 \u0443\u043c\u0435\u043d\u0438\u0435, \u043d\u0430\u043d\u043e\u0441\u044f\u0449\u0435\u0435 \u0443\u0434\u0430\u0440\u044b \u043f\u043e \u0432\u0440\u0430\u0433\u0430\u043c."",
                    ""explicitMods"": [
                        ""\u0423\u0441\u0438\u043b\u0435\u043d\u043d\u044b\u0435 \u0443\u043c\u0435\u043d\u0438\u044f \u0434\u0430\u0440\u0443\u044e\u0442 10% \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u0445\u043e\u043b\u043e\u0434\u0430 \u0432 \u0432\u0438\u0434\u0435 \u0434\u043e\u043f\u043e\u043b\u043d\u0438\u0442\u0435\u043b\u044c\u043d\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u043e\u0433\u043d\u044f"",
                        ""50% \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u0445\u043e\u043b\u043e\u0434\u0430 \u0443\u0441\u0438\u043b\u0435\u043d\u043d\u044b\u0445 \u0443\u043c\u0435\u043d\u0438\u0439 \u0441\u0442\u0430\u043d\u043e\u0432\u0438\u0442\u0441\u044f \u0443\u0440\u043e\u043d\u043e\u043c \u043e\u0442 \u043e\u0433\u043d\u044f""
                    ],
                    ""descrText"": ""\u042d\u0442\u043e \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438. \u041e\u043d \u0434\u0430\u0435\u0442 \u043f\u0440\u0435\u0438\u043c\u0443\u0449\u0435\u0441\u0442\u0432\u0430 \u043d\u0435 \u0433\u0435\u0440\u043e\u044e, \u0430 \u043a\u0430\u043c\u043d\u044e \u0443\u043c\u0435\u043d\u0438\u044f \u0432 \u0441\u0432\u044f\u0437\u0430\u043d\u043d\u044b\u0445 \u0433\u043d\u0435\u0437\u0434\u0430\u0445. \u0412\u0441\u0442\u0430\u0432\u044c\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438 \u0432 \u0433\u043d\u0435\u0437\u0434\u043e, \u0441\u043e\u0435\u0434\u0438\u043d\u0435\u043d\u043d\u043e\u0435 \u0441 \u0433\u043d\u0435\u0437\u0434\u043e\u043c \u0443\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u043c\u043e\u0433\u043e \u043a\u0430\u043c\u043d\u044f \u0430\u043a\u0442\u0438\u0432\u043d\u043e\u0433\u043e \u0443\u043c\u0435\u043d\u0438\u044f. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                    ""frameType"": 4,
                    ""x"": 4,
                    ""y"": 2,
                    ""inventoryId"": ""Stash22"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 2,
                    ""h"": 3,
                    ""ilvl"": 69,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Armours\/BodyArmours\/BodyDexInt1C.png?scale=1&scaleIndex=0&w=2&h=3&v=58c31e9c01e3395af3661627cabc0db53"",
                    ""league"": ""Hardcore"",
                    ""id"": ""af94dfd522678caa10420ab27c5e9b3a07dfdb3e82c9a635c5218dc015beffe6"",
                    ""sockets"": [
                        {
                            ""group"": 0,
                            ""attr"": ""D""
                        },
                        {
                            ""group"": 0,
                            ""attr"": ""D""
                        }
                    ],
                    ""name"": ""<<set:FS>><<set:F>><<set:S>><if:MS>{\u042f\u0440\u043e\u0441\u0442\u043d\u044b\u0439
                    }<elif:FS>{\u042f\u0440\u043e\u0441\u0442\u043d\u0430\u044f
                    }<elif:NS>{\u042f\u0440\u043e\u0441\u0442\u043d\u043e\u0435
                    }<elif:MP>{\u042f\u0440\u043e\u0441\u0442\u043d\u044b\u0435
                    }<elif:FP>{\u042f\u0440\u043e\u0441\u0442\u043d\u044b\u0435
                    }<elif:NP>{\u042f\u0440\u043e\u0441\u0442\u043d\u044b\u0435
                    } \u043e\u043f\u0435\u043a\u0430"",
                    ""typeLine"": ""\u0411\u0430\u0433\u0440\u044f\u043d\u044b\u0439 \u043a\u0430\u043c\u0437\u043e\u043b"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0423\u043a\u043b\u043e\u043d\u0435\u043d\u0438\u0435"",
                            ""values"": [
                                [
                                    ""264"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 17
                        },
                        {
                            ""name"": ""\u042d\u043d\u0435\u0440\u0433\u0435\u0442\u0438\u0447\u0435\u0441\u043a\u0438\u0439 \u0449\u0438\u0442"",
                            ""values"": [
                                [
                                    ""84"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 18
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""51"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041b\u043e\u0432\u043a"",
                            ""values"": [
                                [
                                    ""71"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        },
                        {
                            ""name"": ""\u0418\u043d\u0442"",
                            ""values"": [
                                [
                                    ""71"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""explicitMods"": [
                        ""+93 \u043a \u043c\u0430\u043a\u0441\u0438\u043c\u0443\u043c\u0443 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f"",
                        ""+58 \u043a \u043c\u0430\u043a\u0441\u0438\u043c\u0443\u043c\u0443 \u043c\u0430\u043d\u044b"",
                        ""+32 \u043a \u043c\u0430\u043a\u0441\u0438\u043c\u0443\u043c\u0443 \u044d\u043d\u0435\u0440\u0433\u0435\u0442\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0449\u0438\u0442\u0430"",
                        ""+40% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u043c\u043e\u043b\u043d\u0438\u0438"",
                        ""+22% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u0445\u0430\u043e\u0441\u0443""
                    ],
                    ""craftedMods"": [
                        ""+21% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u0445\u043e\u043b\u043e\u0434\u0443""
                    ],
                    ""frameType"": 2,
                    ""x"": 10,
                    ""y"": 6,
                    ""inventoryId"": ""Stash23"",
                    ""socketedItems"": [
                        
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 2,
                    ""h"": 3,
                    ""ilvl"": 67,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Armours\/Shields\/Riseofthephoenix.png?scale=1&scaleIndex=0&w=2&h=3&v=c7717c4e01b7e50687616c686503971c3"",
                    ""league"": ""Hardcore"",
                    ""id"": ""3feaa536e6710f326cde7880cb44d184803d48f5f1562fa79498506f1199a54b"",
                    ""sockets"": [
                        {
                            ""group"": 0,
                            ""attr"": ""S""
                        },
                        {
                            ""group"": 0,
                            ""attr"": ""S""
                        },
                        {
                            ""group"": 0,
                            ""attr"": ""I""
                        }
                    ],
                    ""name"": ""<<set:MS>><<set:M>><<set:S>>\u0412\u043e\u0437\u0440\u043e\u0436\u0434\u0435\u043d\u0438\u0435 \u0424\u0435\u043d\u0438\u043a\u0441\u0430"",
                    ""typeLine"": ""\u041c\u043e\u0437\u0430\u0438\u0447\u043d\u044b\u0439 \u043a\u0430\u043f\u043b\u0435\u0432\u0438\u0434\u043d\u044b\u0439 \u0449\u0438\u0442"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u0428\u0430\u043d\u0441 \u0437\u0430\u0431\u043b\u043e\u043a\u0438\u0440\u043e\u0432\u0430\u0442\u044c \u0443\u0434\u0430\u0440"",
                            ""values"": [
                                [
                                    ""24%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 15
                        },
                        {
                            ""name"": ""\u0411\u0440\u043e\u043d\u044f"",
                            ""values"": [
                                [
                                    ""265"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 16
                        },
                        {
                            ""name"": ""\u042d\u043d\u0435\u0440\u0433\u0435\u0442\u0438\u0447\u0435\u0441\u043a\u0438\u0439 \u0449\u0438\u0442"",
                            ""values"": [
                                [
                                    ""50"",
                                    1
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 18
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""66"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0421\u0438\u043b\u0430"",
                            ""values"": [
                                [
                                    ""146"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        },
                        {
                            ""name"": ""\u0418\u043d\u0442"",
                            ""values"": [
                                [
                                    ""105"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""implicitMods"": [
                        ""+8% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u0432\u0441\u0435\u043c \u0441\u0442\u0438\u0445\u0438\u044f\u043c""
                    ],
                    ""explicitMods"": [
                        ""80% \u043f\u043e\u0432\u044b\u0448\u0435\u043d\u0438\u0435 \u0431\u0440\u043e\u043d\u0438 \u0438 \u044d\u043d\u0435\u0440\u0433\u0435\u0442\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0449\u0438\u0442\u0430"",
                        ""\u0420\u0435\u0433\u0435\u043d\u0435\u0440\u0438\u0440\u0443\u0435\u0442 6 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f \u0432 \u0441\u0435\u043a\u0443\u043d\u0434\u0443"",
                        ""+8% \u043a \u043c\u0430\u043a\u0441\u0438\u043c\u0430\u043b\u044c\u043d\u043e\u043c\u0443 \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u043e\u0433\u043d\u044e"",
                        ""+21% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u043e\u0433\u043d\u044e"",
                        ""+25% \u043a \u0441\u043e\u043f\u0440\u043e\u0442\u0438\u0432\u043b\u0435\u043d\u0438\u044e \u043e\u0433\u043d\u044e \u043f\u0440\u0438 \u043c\u0430\u043b\u043e\u043c \u043a\u043e\u043b\u0438\u0447\u0435\u0441\u0442\u0432\u0435 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f"",
                        ""10% \u043f\u043e\u0432\u044b\u0448\u0435\u043d\u0438\u0435 \u0441\u043a\u043e\u0440\u043e\u0441\u0442\u0438 \u043f\u0435\u0440\u0435\u0434\u0432\u0438\u0436\u0435\u043d\u0438\u044f \u043f\u0440\u0438 \u043c\u0430\u043b\u043e\u043c \u043a\u043e\u043b\u0438\u0447\u0435\u0441\u0442\u0432\u0435 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f"",
                        ""\u041d\u0435 \u043c\u043e\u0436\u0435\u0442 \u0431\u044b\u0442\u044c \u043f\u043e\u0434\u043e\u0436\u0436\u0451\u043d \u043f\u0440\u0438 \u043c\u0430\u043b\u043e\u043c \u043a\u043e\u043b\u0438\u0447\u0435\u0441\u0442\u0432\u0435 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f""
                    ],
                    ""flavourText"": [
                        ""\u0412\u043b\u0430\u0434\u0435\u044e\u0449\u0438\u0439 \u043c\u043d\u043e\u0439 \u043e\u0433\u0440\u0430\u0436\u0434\u0435\u043d \u043f\u043b\u0430\u043c\u0435\u043d\u0435\u043c,\r"",
                        ""\u0438\u0431\u043e \u044f \u2014 \u0424\u0435\u043d\u0438\u043a\u0441 \u0432 \u0441\u0438\u044f\u043d\u0438\u0438 \u0441\u043b\u0430\u0432\u044b \u0432\u0435\u0447\u043d\u043e\u043c.""
                    ],
                    ""frameType"": 3,
                    ""x"": 4,
                    ""y"": 7,
                    ""inventoryId"": ""Stash24"",
                    ""socketedItems"": [
                        {
                            ""verified"": false,
                            ""w"": 1,
                            ""h"": 1,
                            ""ilvl"": 0,
                            ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/EnduringCry.png?scale=1&scaleIndex=0&w=1&h=1&v=0d2d8a9713adc2828f4626110eaee3ef3"",
                            ""support"": false,
                            ""league"": ""Hardcore"",
                            ""id"": ""e7e027943c35863aee069050f8d21b84d573bb558f2884143a7a8c4a087ff026"",
                            ""sockets"": [
                                
                            ],
                            ""name"": """",
                            ""typeLine"": ""\u041a\u043b\u0438\u0447 \u0441\u0442\u043e\u0439\u043a\u043e\u0441\u0442\u0438"",
                            ""identified"": true,
                            ""corrupted"": false,
                            ""lockedToCharacter"": false,
                            ""properties"": [
                                {
                                    ""name"": ""\u0411\u043e\u0435\u0432\u043e\u0439 \u043a\u043b\u0438\u0447, \u041e\u0431\u043b\u0430\u0441\u0442\u044c, \u0414\u043b\u0438\u0442\u0441\u044f"",
                                    ""values"": [
                                        
                                    ],
                                    ""displayMode"": 0
                                },
                                {
                                    ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                                    ""values"": [
                                        [
                                            ""18"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 0,
                                    ""type"": 5
                                },
                                {
                                    ""name"": ""\u0420\u0430\u0441\u0445\u043e\u0434 \u043c\u0430\u043d\u044b"",
                                    ""values"": [
                                        [
                                            ""21"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 0
                                },
                                {
                                    ""name"": ""\u041f\u0435\u0440\u0435\u0437\u0430\u0440\u044f\u0434\u043a\u0430"",
                                    ""values"": [
                                        [
                                            ""4.00 \u0441\u0435\u043a."",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 0
                                }
                            ],
                            ""additionalProperties"": [
                                {
                                    ""name"": ""\u041e\u043f\u044b\u0442"",
                                    ""values"": [
                                        [
                                            ""47885505\/62872274"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 2,
                                    ""progress"": 0.7616314888000488
                                }
                            ],
                            ""requirements"": [
                                {
                                    ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                                    ""values"": [
                                        [
                                            ""66"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 0
                                },
                                {
                                    ""name"": ""\u0421\u0438\u043b\u0430"",
                                    ""values"": [
                                        [
                                            ""146"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 1
                                }
                            ],
                            ""secDescrText"": ""\u0413\u0435\u0440\u043e\u0439 \u0438\u0437\u0434\u0430\u0451\u0442 \u0431\u043e\u0435\u0432\u043e\u0439 \u043a\u043b\u0438\u0447, \u043f\u043e\u043b\u0443\u0447\u0430\u044f \u0437\u0430\u0440\u044f\u0434\u044b \u0432\u044b\u043d\u043e\u0441\u043b\u0438\u0432\u043e\u0441\u0442\u0438 \u0432 \u0437\u0430\u0432\u0438\u0441\u0438\u043c\u043e\u0441\u0442\u0438 \u043e\u0442 \u043a\u043e\u043b\u0438\u0447\u0435\u0441\u0442\u0432\u0430 \u0432\u0440\u0430\u0433\u043e\u0432 \u0432\u043e\u043a\u0440\u0443\u0433 \u0438 \u0440\u0435\u0433\u0435\u043d\u0435\u0440\u0430\u0446\u0438\u044e \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f. \u0417\u0430\u0441\u0442\u0430\u0432\u043b\u044f\u0435\u0442 \u0432\u0441\u0435\u0445 \u0432\u0440\u0430\u0433\u043e\u0432 \u0430\u0442\u0430\u043a\u043e\u0432\u0430\u0442\u044c \u0441\u0435\u0431\u044f. \u0418\u043c\u0435\u0435\u0442 \u043e\u0431\u0449\u0435\u0435 \u0432\u0440\u0435\u043c\u044f \u043f\u0435\u0440\u0435\u0437\u0430\u0440\u044f\u0434\u043a\u0438 \u0441 \u0434\u0440\u0443\u0433\u0438\u043c\u0438 \u043a\u043b\u0438\u0447\u0430\u043c\u0438."",
                            ""explicitMods"": [
                                ""\u0411\u0430\u0437\u043e\u0432\u0430\u044f \u0434\u043b\u0438\u0442\u0435\u043b\u044c\u043d\u043e\u0441\u0442\u044c: 0.75 \u0441\u0435\u043a\u0443\u043d\u0434"",
                                ""34 \u0437\u0430\u0440\u044f\u0434\u043e\u0432 \u0432\u044b\u043d\u043e\u0441\u043b\u0438\u0432\u043e\u0441\u0442\u0438 \u0434\u0430\u0440\u0443\u0435\u0442\u0441\u044f \u0437\u0430 100 \u0432\u0440\u0430\u0433\u043e\u0432 \u043f\u043e\u0431\u043b\u0438\u0437\u043e\u0441\u0442\u0438"",
                                ""\u0420\u0435\u0433\u0435\u043d\u0435\u0440\u0438\u0440\u0443\u0435\u0442 356 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f \u0432 \u0441\u0435\u043a\u0443\u043d\u0434\u0443""
                            ],
                            ""descrText"": ""\u0414\u043b\u044f \u043f\u043e\u043b\u0443\u0447\u0435\u043d\u0438\u044f \u0443\u043c\u0435\u043d\u0438\u044f \u0432\u044b\u0431\u0435\u0440\u0438\u0442\u0435 \u043f\u0440\u0435\u0434\u043c\u0435\u0442 \u0438 \u043f\u043e\u043c\u0435\u0441\u0442\u0438\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u0432 \u0433\u043d\u0435\u0437\u0434\u043e \u0441\u043e\u043e\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0443\u044e\u0449\u0435\u0433\u043e \u0446\u0432\u0435\u0442\u0430. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                            ""frameType"": 4,
                            ""socket"": 0,
                            ""colour"": ""S"",
                            ""socketedItems"": [
                                
                            ]
                        },
                        {
                            ""verified"": false,
                            ""w"": 1,
                            ""h"": 1,
                            ""ilvl"": 0,
                            ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/Support\/IncreasedDuration.png?scale=1&scaleIndex=0&w=1&h=1&v=14b3a91933f0b921d1b573358e31f7683"",
                            ""support"": true,
                            ""league"": ""Hardcore"",
                            ""id"": ""686c7bd8355bd947349f8bcdf60941fc7b0b80a8373a50357434e0be31cabdd6"",
                            ""sockets"": [
                                
                            ],
                            ""name"": """",
                            ""typeLine"": ""\u041f\u0440\u043e\u0434\u043b\u0435\u043d\u0438\u0435"",
                            ""identified"": true,
                            ""corrupted"": false,
                            ""lockedToCharacter"": false,
                            ""properties"": [
                                {
                                    ""name"": ""\u041f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0430, \u0414\u043b\u0438\u0442\u0441\u044f"",
                                    ""values"": [
                                        
                                    ],
                                    ""displayMode"": 0
                                },
                                {
                                    ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                                    ""values"": [
                                        [
                                            ""18"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 0,
                                    ""type"": 5
                                },
                                {
                                    ""name"": ""\u041c\u043d\u043e\u0436\u0438\u0442\u0435\u043b\u044c \u043c\u0430\u043d\u044b"",
                                    ""values"": [
                                        [
                                            ""140%"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 0
                                }
                            ],
                            ""additionalProperties"": [
                                {
                                    ""name"": ""\u041e\u043f\u044b\u0442"",
                                    ""values"": [
                                        [
                                            ""39499861\/62460771"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 2,
                                    ""progress"": 0.6323946714401245
                                }
                            ],
                            ""requirements"": [
                                {
                                    ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                                    ""values"": [
                                        [
                                            ""66"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 0
                                },
                                {
                                    ""name"": ""\u0421\u0438\u043b\u0430"",
                                    ""values"": [
                                        [
                                            ""105"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 1
                                }
                            ],
                            ""secDescrText"": ""\u0423\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u0442 \u043b\u044e\u0431\u043e\u0435 \u0443\u043c\u0435\u043d\u0438\u0435 \u0441 \u0432\u0440\u0435\u043c\u0435\u043d\u0435\u043c \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044f."",
                            ""explicitMods"": [
                                ""\u0423\u0441\u0438\u043b\u0435\u043d\u043d\u044b\u0435 \u0443\u043c\u0435\u043d\u0438\u044f \u0438\u043c\u0435\u044e\u0442 62% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0434\u043b\u0438\u0442\u0435\u043b\u044c\u043d\u043e\u0441\u0442\u0438 \u044d\u0444\u0444\u0435\u043a\u0442\u043e\u0432 \u0443\u043c\u0435\u043d\u0438\u0439""
                            ],
                            ""descrText"": ""\u042d\u0442\u043e \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438. \u041e\u043d \u0434\u0430\u0435\u0442 \u043f\u0440\u0435\u0438\u043c\u0443\u0449\u0435\u0441\u0442\u0432\u0430 \u043d\u0435 \u0433\u0435\u0440\u043e\u044e, \u0430 \u043a\u0430\u043c\u043d\u044e \u0443\u043c\u0435\u043d\u0438\u044f \u0432 \u0441\u0432\u044f\u0437\u0430\u043d\u043d\u044b\u0445 \u0433\u043d\u0435\u0437\u0434\u0430\u0445. \u0412\u0441\u0442\u0430\u0432\u044c\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438 \u0432 \u0433\u043d\u0435\u0437\u0434\u043e, \u0441\u043e\u0435\u0434\u0438\u043d\u0435\u043d\u043d\u043e\u0435 \u0441 \u0433\u043d\u0435\u0437\u0434\u043e\u043c \u0443\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u043c\u043e\u0433\u043e \u043a\u0430\u043c\u043d\u044f \u0430\u043a\u0442\u0438\u0432\u043d\u043e\u0433\u043e \u0443\u043c\u0435\u043d\u0438\u044f. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                            ""frameType"": 4,
                            ""socket"": 1,
                            ""colour"": ""S"",
                            ""socketedItems"": [
                                
                            ]
                        },
                        {
                            ""verified"": false,
                            ""w"": 1,
                            ""h"": 1,
                            ""ilvl"": 0,
                            ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/Support\/IncreasedAOE.png?scale=1&scaleIndex=0&w=1&h=1&v=f0accbe4733628f443cd691574b3f6043"",
                            ""support"": true,
                            ""league"": ""Hardcore"",
                            ""id"": ""c3cc79559772ddaadafad2c5d4ad92d3ab2ba95fe85fa13855228063b5c9e23b"",
                            ""sockets"": [
                                
                            ],
                            ""name"": """",
                            ""typeLine"": ""\u0420\u0430\u0441\u0448\u0438\u0440\u0435\u043d\u043d\u0430\u044f \u043e\u0431\u043b\u0430\u0441\u0442\u044c \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044f"",
                            ""identified"": true,
                            ""corrupted"": false,
                            ""lockedToCharacter"": false,
                            ""properties"": [
                                {
                                    ""name"": ""\u041f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0430, \u041e\u0431\u043b\u0430\u0441\u0442\u044c"",
                                    ""values"": [
                                        
                                    ],
                                    ""displayMode"": 0
                                },
                                {
                                    ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                                    ""values"": [
                                        [
                                            ""16"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 0,
                                    ""type"": 5
                                },
                                {
                                    ""name"": ""\u041c\u043d\u043e\u0436\u0438\u0442\u0435\u043b\u044c \u043c\u0430\u043d\u044b"",
                                    ""values"": [
                                        [
                                            ""140%"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 0
                                }
                            ],
                            ""additionalProperties"": [
                                {
                                    ""name"": ""\u041e\u043f\u044b\u0442"",
                                    ""values"": [
                                        [
                                            ""11781205\/16159983"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 2,
                                    ""progress"": 0.7290357351303101
                                }
                            ],
                            ""requirements"": [
                                {
                                    ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                                    ""values"": [
                                        [
                                            ""66"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 0
                                },
                                {
                                    ""name"": ""\u0418\u043d\u0442"",
                                    ""values"": [
                                        [
                                            ""105"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 1
                                }
                            ],
                            ""secDescrText"": ""\u0423\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u0442 \u043b\u044e\u0431\u043e\u0435 \u0443\u043c\u0435\u043d\u0438\u0435 \u0441 \u043e\u0431\u043b\u0430\u0441\u0442\u044c\u044e \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044f."",
                            ""explicitMods"": [
                                ""\u0423\u0441\u0438\u043b\u0435\u043d\u043d\u044b\u0435 \u0443\u043c\u0435\u043d\u0438\u044f \u0438\u043c\u0435\u044e\u0442 45% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u043e\u0431\u043b\u0430\u0441\u0442\u0438 \u0434\u0435\u0439\u0441\u0442\u0432\u0438\u044f""
                            ],
                            ""descrText"": ""\u042d\u0442\u043e \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438. \u041e\u043d \u0434\u0430\u0435\u0442 \u043f\u0440\u0435\u0438\u043c\u0443\u0449\u0435\u0441\u0442\u0432\u0430 \u043d\u0435 \u0433\u0435\u0440\u043e\u044e, \u0430 \u043a\u0430\u043c\u043d\u044e \u0443\u043c\u0435\u043d\u0438\u044f \u0432 \u0441\u0432\u044f\u0437\u0430\u043d\u043d\u044b\u0445 \u0433\u043d\u0435\u0437\u0434\u0430\u0445. \u0412\u0441\u0442\u0430\u0432\u044c\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u043f\u043e\u0434\u0434\u0435\u0440\u0436\u043a\u0438 \u0432 \u0433\u043d\u0435\u0437\u0434\u043e, \u0441\u043e\u0435\u0434\u0438\u043d\u0435\u043d\u043d\u043e\u0435 \u0441 \u0433\u043d\u0435\u0437\u0434\u043e\u043c \u0443\u0441\u0438\u043b\u0438\u0432\u0430\u0435\u043c\u043e\u0433\u043e \u043a\u0430\u043c\u043d\u044f \u0430\u043a\u0442\u0438\u0432\u043d\u043e\u0433\u043e \u0443\u043c\u0435\u043d\u0438\u044f. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                            ""frameType"": 4,
                            ""socket"": 2,
                            ""colour"": ""I"",
                            ""socketedItems"": [
                                
                            ]
                        }
                    ]
                },
                {
                    ""verified"": false,
                    ""w"": 2,
                    ""h"": 2,
                    ""ilvl"": 69,
                    ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Weapons\/OneHandWeapons\/Claws\/CybilsClaw.png?scale=1&scaleIndex=0&w=2&h=2&v=37a03a007ecf0dc09b4142983b3333f83"",
                    ""league"": ""Hardcore"",
                    ""id"": ""292b2df0fbe5b841c0effc7159d4fae32e200469e8c59cfe193a367a589b0974"",
                    ""sockets"": [
                        {
                            ""group"": 0,
                            ""attr"": ""I""
                        },
                        {
                            ""group"": 0,
                            ""attr"": ""D""
                        }
                    ],
                    ""name"": ""<<set:MS>><<set:M>><<set:S>>\u041b\u0430\u043f\u043a\u0430 \u0421\u0438\u0431\u0435\u043b\u044b"",
                    ""typeLine"": ""\u041a\u0430\u0441\u0442\u0435\u0442 \u043c\u043e\u043b\u043e\u0442\u0438\u043b\u044c\u0449\u0438\u043a\u0430"",
                    ""identified"": true,
                    ""corrupted"": false,
                    ""lockedToCharacter"": false,
                    ""properties"": [
                        {
                            ""name"": ""\u041a\u043e\u0433\u0442\u0438"",
                            ""values"": [
                                
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u0424\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u0438\u0439 \u0443\u0440\u043e\u043d"",
                            ""values"": [
                                [
                                    ""20-53"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 9
                        },
                        {
                            ""name"": ""\u0428\u0430\u043d\u0441 \u043a\u0440\u0438\u0442\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0434\u0430\u0440\u0430"",
                            ""values"": [
                                [
                                    ""6.50%"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 12
                        },
                        {
                            ""name"": ""\u0410\u0442\u0430\u043a \u0432 \u0441\u0435\u043a\u0443\u043d\u0434\u0443"",
                            ""values"": [
                                [
                                    ""1.30"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 13
                        },
                        {
                            ""name"": ""\u0414\u0430\u043b\u044c\u043d\u043e\u0441\u0442\u044c \u043e\u0440\u0443\u0436\u0438\u044f"",
                            ""values"": [
                                [
                                    ""9"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0,
                            ""type"": 14
                        }
                    ],
                    ""requirements"": [
                        {
                            ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                            ""values"": [
                                [
                                    ""68"",
                                    0
                                ]
                            ],
                            ""displayMode"": 0
                        },
                        {
                            ""name"": ""\u041b\u043e\u0432\u043a"",
                            ""values"": [
                                [
                                    ""53"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        },
                        {
                            ""name"": ""\u0418\u043d\u0442"",
                            ""values"": [
                                [
                                    ""151"",
                                    0
                                ]
                            ],
                            ""displayMode"": 1
                        }
                    ],
                    ""implicitMods"": [
                        ""+21 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f \u0437\u0430 \u043a\u0430\u0436\u0434\u043e\u0433\u043e \u0437\u0430\u0434\u0435\u0442\u043e\u0433\u043e \u0430\u0442\u0430\u043a\u043e\u0439 \u0432\u0440\u0430\u0433\u0430""
                    ],
                    ""explicitMods"": [
                        ""11% \u043f\u043e\u0432\u044b\u0448\u0435\u043d\u0438\u0435 \u0441\u043a\u043e\u0440\u043e\u0441\u0442\u0438 \u0441\u043e\u0442\u0432\u043e\u0440\u0435\u043d\u0438\u044f \u0447\u0430\u0440"",
                        ""+38 \u043a \u043c\u0430\u043a\u0441\u0438\u043c\u0443\u043c\u0443 \u043c\u0430\u043d\u044b"",
                        ""+7 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f \u0437\u0430 \u043a\u0430\u0436\u0434\u043e\u0433\u043e \u0437\u0430\u0434\u0435\u0442\u043e\u0433\u043e \u0447\u0430\u0440\u0430\u043c\u0438 \u0432\u0440\u0430\u0433\u0430"",
                        ""8% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u0443\u0440\u043e\u043d\u0430 \u043e\u0442 \u0447\u0430\u0440 \u0437\u0430 5% \u0448\u0430\u043d\u0441\u0430 \u0431\u043b\u043e\u043a\u0430""
                    ],
                    ""flavourText"": [
                        ""\u0423\u043c\u0435\u0440\u044c \u043f\u043e\u0441\u0442\u0443\u043f\u044c \u0438 \u043d\u0435 \u0432\u0441\u0442\u0440\u0435\u0432\u043e\u0436\u0438\u0448\u044c \u0431\u0434\u044f\u0449\u0438\u0445.\r"",
                        ""\u0423\u043c\u0435\u0440\u044c \u043f\u044b\u043b \u0438 \u043d\u0435 \u0432\u0441\u0442\u0440\u0435\u0442\u0438\u0448\u044c \u043e\u0442\u043f\u043e\u0440.\r"",
                        ""\u0423\u043c\u0435\u0440\u044c \u0441\u0438\u043b\u0443 \u0438 \u043d\u0435 \u043f\u0440\u043e\u0433\u043d\u0435\u0432\u0438\u0448\u044c \u0434\u0443\u0445 \u0443\u043c\u0438\u0440\u0430\u044e\u0449\u0435\u0433\u043e.""
                    ],
                    ""frameType"": 3,
                    ""x"": 6,
                    ""y"": 8,
                    ""inventoryId"": ""Stash25"",
                    ""socketedItems"": [
                        {
                            ""verified"": false,
                            ""w"": 1,
                            ""h"": 1,
                            ""ilvl"": 0,
                            ""icon"": ""https:\/\/web.poecdn.com\/image\/Art\/2DItems\/Gems\/ChaosElementalSummon.png?scale=1&scaleIndex=0&w=1&h=1&v=1b72d2848411f3b3bb92c4ad588ce0c53"",
                            ""support"": false,
                            ""league"": ""Hardcore"",
                            ""id"": ""3dd99aaecca493fb06ea7d62c9064724c3fb4e0a743957a3300564d2ac0d0b98"",
                            ""sockets"": [
                                
                            ],
                            ""name"": """",
                            ""typeLine"": ""\u041f\u0440\u0438\u0437\u044b\u0432 \u0433\u043e\u043b\u0435\u043c\u0430 \u0445\u0430\u043e\u0441\u0430"",
                            ""identified"": true,
                            ""corrupted"": false,
                            ""lockedToCharacter"": false,
                            ""properties"": [
                                {
                                    ""name"": ""\u0425\u0430\u043e\u0441, \u041f\u0440\u0438\u0441\u043f\u0435\u0448\u043d\u0438\u043a, \u0427\u0430\u0440\u044b, \u0413\u043e\u043b\u0435\u043c"",
                                    ""values"": [
                                        
                                    ],
                                    ""displayMode"": 0
                                },
                                {
                                    ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                                    ""values"": [
                                        [
                                            ""18"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 0,
                                    ""type"": 5
                                },
                                {
                                    ""name"": ""\u0420\u0430\u0441\u0445\u043e\u0434 \u043c\u0430\u043d\u044b"",
                                    ""values"": [
                                        [
                                            ""52"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 0
                                },
                                {
                                    ""name"": ""\u041f\u0435\u0440\u0435\u0437\u0430\u0440\u044f\u0434\u043a\u0430"",
                                    ""values"": [
                                        [
                                            ""6.00 \u0441\u0435\u043a."",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 0
                                },
                                {
                                    ""name"": ""\u0412\u0440\u0435\u043c\u044f \u043f\u0440\u0438\u043c\u0435\u043d\u0435\u043d\u0438\u044f"",
                                    ""values"": [
                                        [
                                            ""1.00 \u0441\u0435\u043a."",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 0
                                }
                            ],
                            ""additionalProperties"": [
                                {
                                    ""name"": ""\u041e\u043f\u044b\u0442"",
                                    ""values"": [
                                        [
                                            ""33579553\/87248039"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 2,
                                    ""progress"": 0.3848745822906494
                                }
                            ],
                            ""requirements"": [
                                {
                                    ""name"": ""\u0423\u0440\u043e\u0432\u0435\u043d\u044c"",
                                    ""values"": [
                                        [
                                            ""68"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 0
                                },
                                {
                                    ""name"": ""\u0418\u043d\u0442"",
                                    ""values"": [
                                        [
                                            ""151"",
                                            0
                                        ]
                                    ],
                                    ""displayMode"": 1
                                }
                            ],
                            ""secDescrText"": ""\u0413\u0435\u0440\u043e\u0439 \u0432\u044b\u0437\u044b\u0432\u0430\u0435\u0442 \u0433\u043e\u043b\u0435\u043c\u0430 \u0445\u0430\u043e\u0441\u0430, \u043a\u043e\u0442\u043e\u0440\u044b\u0439 \u0441\u043d\u0438\u0436\u0430\u0435\u0442 \u0432\u0445\u043e\u0434\u044f\u0449\u0438\u0439 \u0444\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u0438\u0439 \u0443\u0440\u043e\u043d \u043f\u043e \u0433\u0435\u0440\u043e\u044e \u043f\u043e\u043a\u0430 \u0430\u043a\u0442\u0438\u0432\u0435\u043d. \u041a\u0440\u043e\u043c\u0435 \u043e\u0431\u044b\u0447\u043d\u044b\u0445 \u0443\u0434\u0430\u0440\u043e\u0432 \u0433\u043e\u043b\u0435\u043c \u0438\u0441\u043f\u043e\u043b\u044c\u0437\u0443\u0435\u0442 \u0430\u0443\u0440\u0443 \u0443\u0440\u043e\u043d\u0430 \u0445\u0430\u043e\u0441\u043e\u043c \u0438 \u043a\u0430\u0441\u043a\u0430\u0434 \u0448\u0438\u043f\u043e\u0432 \u0445\u0430\u043e\u0441\u0430."",
                            ""explicitMods"": [
                                ""\u041c\u043e\u0436\u043d\u043e \u043f\u0440\u0438\u0437\u0432\u0430\u0442\u044c 1 \u0433\u043e\u043b\u0435\u043c\u0430"",
                                ""64% \u0443\u0432\u0435\u043b\u0438\u0447\u0435\u043d\u0438\u0435 \u043c\u0430\u043a\u0441\u0438\u043c\u0443\u043c\u0430 \u0437\u0434\u043e\u0440\u043e\u0432\u044c\u044f \u043f\u0440\u0438\u0441\u043f\u0435\u0448\u043d\u0438\u043a\u043e\u0432"",
                                ""\u0413\u043e\u043b\u0435\u043c\u044b \u0434\u0430\u0440\u0443\u044e\u0442 4% \u0434\u043e\u043f\u043e\u043b\u043d\u0438\u0442\u0435\u043b\u044c\u043d\u043e\u0433\u043e \u0441\u043d\u0438\u0436\u0435\u043d\u0438\u044f \u043f\u043e\u043b\u0443\u0447\u0430\u0435\u043c\u043e\u0433\u043e \u0444\u0438\u0437\u0438\u0447\u0435\u0441\u043a\u043e\u0433\u043e \u0443\u0440\u043e\u043d\u0430""
                            ],
                            ""descrText"": ""\u0414\u043b\u044f \u043f\u043e\u043b\u0443\u0447\u0435\u043d\u0438\u044f \u0443\u043c\u0435\u043d\u0438\u044f \u0432\u044b\u0431\u0435\u0440\u0438\u0442\u0435 \u043f\u0440\u0435\u0434\u043c\u0435\u0442 \u0438 \u043f\u043e\u043c\u0435\u0441\u0442\u0438\u0442\u0435 \u043a\u0430\u043c\u0435\u043d\u044c \u0432 \u0433\u043d\u0435\u0437\u0434\u043e \u0441\u043e\u043e\u0442\u0432\u0435\u0442\u0441\u0442\u0432\u0443\u044e\u0449\u0435\u0433\u043e \u0446\u0432\u0435\u0442\u0430. \u0429\u0435\u043b\u043a\u043d\u0438\u0442\u0435 \u041f\u041a\u041c, \u0447\u0442\u043e\u0431\u044b \u0432\u044b\u043d\u0443\u0442\u044c \u043a\u0430\u043c\u0435\u043d\u044c \u0438\u0437 \u0433\u043d\u0435\u0437\u0434\u0430."",
                            ""frameType"": 4,
                            ""socket"": 0,
                            ""colour"": ""I"",
                            ""socketedItems"": [
                                
                            ]
                        }
                    ]
                }
            ],
            ""public"": true
        }
    ]
}";

		#endregion

		public Result GetStashes()
		{
			InternalResult a = JsonConvert.DeserializeObject<InternalResult>(json);

			var stashes = Mapper.Map(a);
			return stashes;
		}
	}
}
