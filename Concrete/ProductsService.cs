using Services.Abstract;
using Services.Exceptions;
using Services.Models.Products;
using Services.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Concrete
{
    public class ProductsService : IProductsService
    {
        private static ProductModel tt12s = new ProductModel(
            "tt-12s",
            "Electronic Drum Kit TT-12S",
            "Product/drums-TT-12S.jpg",
            "Banners/tt-12s-drum-kit.jpg",
            new ContentSectionModel[] {
                new ParagraphSectionModel(
                    "The TOURTECH TT-12S is the perfect entry point for new drummers to begin their experience of playing digital drums. This is the most simple and compact of the kits available and is perfect for bedrooms and small spaces."
                ),
                new ParagraphSectionModel(
                    "The stand comes partially built out of the box so you’ll have your TT-12S up and running in no time! The stand holds all of the drum pads and cymbals: that means the snare, hi-hat, toms, crash cymbal and ride cymbal are fit onto this stand, otherwise known as a ‘rack’. The rack is more sturdy than other models in this price range and the pads feel dynamic and satisfying to play on."
                ),
                new VideoSectionModel(
                    "https://www.youtube-nocookie.com/embed/bx8c83gB2vs"
                ),
                new ParagraphSectionModel(
                    "There is a built in adjustable click track to play along with plus an Aux-in jack for device connectivity: jam along with your favourite mp3s via your phone or other device: you’ll get both your drum sounds plus your chosen track coming through your headphones."
                ),
                new ParagraphSectionModel(
                    "With the TT-12S, you can set up anywhere, even a small space, and begin learning and playing drums with a kit that feels and sounds far superior to anything else in its price range."
                ),
                new ParagraphSectionModel(
                    "The snare pad has ‘dual zone’ technology: there are two independent sensors within it to let you trigger both a full-on snare sound and a ‘rim’ sound, which simulates the technique of playing the edge of the snare drum rather than the centre. This feature is normally not available on kits of this price!"
                ),
                new ImageSectionModel(
                    new ImageModel("TOURTECH drum close up with drum sticks", "Product/Lifestyle/TOURTECH-drums-1.jpg")
                ),
                new ParagraphSectionModel(
                    "The module, or ‘brain’ unit is where all of the processing happens. The module for the TT-12S connects to the rack and has an easy to use front panel with a digital display to help you navigate the 200+ sounds on board. You get 20 preset drum kits included with options to make up 10 of your own."
                ),
                new ParagraphSectionModel(
                    "The module lets you make adjustments for overall sensitivity, tempo of tracks, addition of a reverb effect and lots more."
                ),
                new ParagraphSectionModel(
                    "Each kit is supplied with a robust stand upon which the drum pads, cymbal pads and module are connected. This is actually partially built right out of the box so attaching pads and connecting cables is simplicity itself."
                ),
                new ImageSectionModel(
                    new ImageModel("TOURTECH drum close up with drum sticks", "Product/Lifestyle/TOURTECH-drums-2.jpg")
                ),
                new ParagraphSectionModel(
                    "TOURTECH kits all feature a library of sampled drum sounds that encompass realistic acoustic kits sounds and a variety of famous drum machine sounds. You can change the entire sound of the kit at the touch of a button and also record your performance into the brain unit of models like the TT-12S so you can listen back and gauge how much you are improving!"
                ),
                new ParagraphSectionModel(
                    "All TOURTECH kits have MIDI and USB functionality. This means that every TOURTECH kit can be easily connected to a computer to record performances directly onto your recording software. Doing this is a simple and easy way for any drummer to record a high quality stereo drum performance. MIDI also lets you connect additional pieces of technology and hardware available separately. This means you can expand your equipment as your technique and experience grows."
                ),
                new ParagraphSectionModel(
                    "The TOURTECH range of digital drums comprises of four kits, each of which containing a plethora of features and all displaying great value for money. Let us take a closer look at this model:"
                )

            },
            new ImageModel[] {
                new ImageModel("TT-12S electronic drum kit", "Product/TT-12S-drums-gallery-1.jpg"),
                new ImageModel("TT-12S digital control panel", "Product/TT-12S-drums-gallery-2.jpg"),
                new ImageModel("TT-12S inputs and outputs", "Product/TT-12S-drums-gallery-3.jpg")
            },
            new string[] {
                "Donec vel lacus mi. Ut consectetur non lacus eu ultricies. Nullam id tempor odio. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Duis sed ligula non purus mollis dapibus eu vitae ipsum. Nunc mollis tellus vel est pulvinar, ut interdum sapien dapibus. Integer egestas vulputate venenatis.",
                "Proin lobortis lacinia risus, sed tempor enim vehicula vel. Vestibulum elit elit, fermentum non ipsum at, condimentum euismod libero. Nulla in est vitae augue varius ultrices. Integer ultrices tristique pretium. Suspendisse ut ligula vel lectus ullamcorper bibendum sit amet ac lacus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nullam ac placerat ex, vel commodo diam. Duis ultricies malesuada arcu vel egestas. Nunc vitae dolor semper, auctor est eget, vestibulum enim"
            },
            new string[] {
                "Complete 7-Piece Electric Drum Kit",
                "Ergonomically designed rack-system with easy set-up and fold-down feature",
                "250 high quality percussion voices",
                "20 preset drum kits + 10 user defined drums kits",
                "20 demo songs",
                "Dynamic, real-feel cymbal and drum pads",
                "Expressive hi-hat and bass drum pedals",
                "Digital Display",
                "Built-In Song Playback and Recording",
                "Click Track / Metronome",
                "Aux-in for MP3 connectivity - Play along to your favourite artists",
                "Trigger Curve Settings",
                "Adjustable Sensitivity and Crosstalk",
                "Reverb Effect",
                "Connect to your computer via USB",
                "2 x 1/4\" TRS Jack Line Master Outputs",
                "MIDI In and Out, USB Connectivity",
                "Complete Kit with sticks included"
            },
            new MetaDataModel(
                "TOURTECH TT-12S – Affordable Electronic Drums & Percussion",
                "Have fun learning to play the drums with the TOURTECH TT-12S electric drum kit. Play, practise and record your performances with TOURTECH the TT-12S."
            )
        );

        private static ProductModel tt22m = new ProductModel(
            "tt-22m", "Electronic Drum Kit with Mesh Heads TT-22M", "Product/drums-TT-22M.jpg", "Banners/drums-alt.jpg",
            new ContentSectionModel[] {
                new ParagraphSectionModel(
                    "The TOURTECH TT-22M is the top of the range TOURTECH electric drum kit. This fully featured, mesh padded kit is bursting at the seams with pro features and still manages to be compact, portable and super-affordable."
                ),
                new VideoSectionModel(
                    "https://www.youtube-nocookie.com/embed/zgrwG1mezsE"
                ),
                new ParagraphSectionModel(
                    "TOURTECH have put together a kit with lots of extra benefits over the rest of the range: benefits that players of all experience and skill levels will appreciate."
                ),
                new ParagraphSectionModel(
                    "The frame (or ‘rack’) of the TT-22M is larger than the TT-12 models but is still eminently compact and portable. This kit sets up quickly and easily out of the box: the main rack is already built which is a time saver! It is also robustly made and ready for a long life of setting up, moving around and playing."
                ),
                new ImageSectionModel(
                    new ImageModel("Playing TOURTECH drums", "Product/Lifestyle/TOURTECH-drums-3.jpg")
                ),
                new ParagraphSectionModel(
                    "All of the drum pads have fully responsive mesh heads for a realistic and articulate performance. Mesh heads really give an edge over more simple pads: you can enjoy a proper rebound with these and an increased stick feel. Under the mesh, these pads all have ‘Dual Zone’ technology to incorporate more realistic sound variations. These mesh heads are also adjustable to allow you to zone in on the tension level you prefer."
                ),
                new ParagraphSectionModel(
                    "The cymbals have the same “Dual Zone’ technology employed to not only allow for much greater dynamic variation but also for ‘choking’ the sound by hand: an essential technique in any drummer’s vocabulary."
                ),
                new ParagraphSectionModel(
                    "The TT-22M module has a huge amount of sounds and kits: 458 voices with 26 preset kits to use straightaway and a further 15 kits which are user-editable."
                ),
                new ImageSectionModel(
                    new ImageModel("Playing TOURTECH drums close up", "Product/Lifestyle/TOURTECH-drums-4.jpg")
                ),
                new ParagraphSectionModel(
                    "20 demo songs are also included within the module for instant jamming fun but you can also take advantage of the built in Aux-in jack to connect your phone or other device for jamming to your favourite songs."
                ),
                new ParagraphSectionModel(
                    "USB and MIDI connectivity is included to increase functionality significantly. Trigger separate outboard devices with your drums and record entire tracks of drums to your computer, all stereo panned as they are in your headphones!"
                ),
                new ParagraphSectionModel(
                    "Extra enhanced functions include a 3 band EQ section, two different reverb settings and editable drum sounds."
                ),
                new ParagraphSectionModel(
                    "This flagship TT-22M kit is a fantastic choice for everybody who requires a full mesh kit with a solid rack and a great price! Whether you are just starting out, a producer needing a great way to record drum performances or a seasoned player looking  for a compact, feature-laden kit that demonstrates tremendous value, the TOURTECH TT-22M is the one for you."
                )
            }, 
            new ImageModel[] {
                new ImageModel("TT-22M electronic drum kit", "Product/TT-22M-drums-gallery-1.jpg"),
                new ImageModel("TT-22M drum pad close up", "Product/TT-22M-drums-gallery-2.jpg"),
                new ImageModel("TT-22M digital control panel", "Product/TT-22M-drums-gallery-3.jpg"),
                new ImageModel("TT-22M inputs and outputs", "Product/TT-22M-drums-gallery-4.jpg")   
            },
            new string[] { }, new string[] {
                "Complete 8-Piece Electric Drum kit",
                "'Fold-Out and Play' Ergonomic Rack Stand",
                "128 x 64 character LCD display",
                "458 high quality percussion voices",
                "26 preset drum kits + 15 user-defined drum kits",
                "20 demo songs",
                "Dual-Zone, round cymbal pads with \"Choke\" function",
                "Dual-zone, tensionable, mesh-head tom-pads",
                "10\" tensionable mesh-head snare drum with Cross-stick and Rim-Shot function",
                "Upright, mesh-head bass drum pad with bass drum pedal",
                "Aux In jack for MP3 Playback",
                "Line output, Headphone output",
                "USB interface (USB to device), MIDI IN/OUT",
                "Recording and playback functionality",
                "Adjustable sensitivity and crosstalk",
                "Metronome: 3 band EQ, 3 ambience and 2 reverb settings"
            },
            new MetaDataModel(
                "TOURTECH TT-22M electric drum - Learn in style with our fully meshed drum kit",
                "Learn and practise in style with the fully mesh headed TOURTECH TT-22M digital drum kit. Enjoy a more realistic playing experience with an upgraded feel."
            )
        );

        private static ProductModel tt12sm = new ProductModel(
            "tt-12sm", "Electronic Drum Kit with Mesh Snare TT-12SM", "Product/drums-TT-12SM.jpg", "Banners/tt-12sm-drum-kit.jpg",
            new ContentSectionModel[] {
                new ParagraphSectionModel(
                    "The TOURTECH TT-12SM builds on the quality and value of the excellent TT-12S and adds the major benefit of a mesh snare pad! This adds a lot to the quality of playing experience and is a feature that’s normally only on significantly more expensive kits."
                ),
                new VideoSectionModel(
                    "https://www.youtube-nocookie.com/embed/WbyTNiroWRg"
                ),
                new ParagraphSectionModel(
                    "The TOURTECH TT-12SM has the same compact footprint as the TT-12S, so you can set this up in a bedroom or study without taking up too much room. This kit is designed to make minimum noise so you’ll be able to jam any time you like without provoking any knocks at the door!"
                ),
                new ImageSectionModel(
                    new ImageModel("Playing TOURTECH drums", "Product/Lifestyle/TOURTECH-drums-5.jpg")
                ),
                new ParagraphSectionModel(
                    "The TT-12SM is a fantastic value kit for beginners, students and all drummers looking for a digital kit to practise on. The snare on this kit has a fantastic mesh head for a realistic feel and response. This makes a big difference to your enjoyment of playing: the snare is integral to every drum part and so the more realistic, the better! The other great benefit and upgrade here is the kick pad and proper kick pedal. With a real, functioning beater, this kick drum setup is more physical and realistic, bringing more out of each performance. With over 250 sounds to play with and 20 presets kits (a further 10 are user-defined), there is plenty onboard to get you instantly practising and playing. An onboard metronome gives you a pulse to practise along to whilst an Aux-in jack lets you connect a device and jam along to your favourite songs."
                ),
                new ParagraphSectionModel(
                    "Selecting kits and other functions is a simple affair via the easy to navigate module. A bright digital display and a selection of buttons let you select kits, set up the metronome and even record your playing! Now you can listen back to your performance to gauge your progress and improvement! You can also change the velocity sensitivity of the triggers for the pads in order to further tailor the kit to your playing preference."
                ),
                new ParagraphSectionModel(
                    "MIDI and USB connectivity lets you hook your TT-12SM to a computer for hassle-free recording and also triggering other pieces of gear. This type of open-ended possibility enhances the value of this kit significantly. Producers on a budget can use the TT-12SM as an effective device for getting realistic performances for their recording projects."
                ),
                new ImageSectionModel(
                    new ImageModel("Playing two TOURTECH drum kits", "Product/Lifestyle/TOURTECH-drums-6.jpg")
                ),
                new ParagraphSectionModel(
                    "Other great details include a bass drum pedal with a proper mini-pad for a natural feel and response and an included set of sticks to begin playing right out of the box."
                ),
                new ParagraphSectionModel(
                    "The TOURTECH TT-12SM is a fantastic value digital kit that combines pro features with ease of use. Every aspiring drummer will love learning on this and every experienced drummer will love the compact size and mesh head."
                )
            }, new ImageModel[] {
                new ImageModel("TT-12SM electronic drum kit", "Product/TT-12SM-drums-gallery-1.jpg"),
                new ImageModel("TT-12SM drum pad close up", "Product/TT-12SM-drums-gallery-2.jpg"),
                new ImageModel("TT-12SM kick pedal", "Product/TT-12SM-drums-gallery-3.jpg"),
                new ImageModel("TT-12SM digital control panel", "Product/TT-12SM-drums-gallery-4.jpg")
            },
            new string[] { }, new string[] {
                "Complete 7-Piece Electric Drum Kit",
                "Ergonomically designed rack-system with easy set-up and fold-down feature",
                "250 high quality percussion voices",
                "20 preset drum kits + 10 user defined drums kits",
                "20 demo songs",
                "Dual Zone Mesh Snare Drum",
                "Responsive Kick Pedal and Trigger Pad",
                "Dynamic, real-feel cymbal and drum pads",
                "Expressive hi-hat pedal",
                "Digital Display",
                "Built-In Song Playback and Recording",
                "Click Track / Metronome",
                "Aux-in for MP3 connectivity - Play along to your favourite artists",
                "Trigger Curve Settings",
                "Adjustable Sensitivity and Crosstalk",
                "Reverb Effect",
                "Connect to your computer via USB",
                "2 x 1/4\" TRS Jack Line Master Outputs",
                "MIDI In and Out, USB Connectivity",
                "Complete Kit with sticks included"
            },
            new MetaDataModel(
                "TOURTECH TT-12SM – Affordable Electronic Drum Kit with Mesh Snare",
                "Enhance your learning experience with the TOURTECH TT-12SM. Enjoy the feel of a mesh snare and full USB connectivity wit this fully featured kit."
            )
        );

        private static ProductModel tt16s = new ProductModel(
            "tt-16s", "Electronic Drum Kit TT-16S", "Product/drums-TT-16S.jpg", "Banners/drums-alt.jpg",
            new ContentSectionModel[] {
                new ParagraphSectionModel(
                    "The TOURTECH TT-16S brings a host of upgrades and professional features to the range whilst still bringing outstanding value. Almost every detail of the TT-16S has been upgraded: the frame, the module, the pads, the kick pedal and the cymbals. Significantly, this translates to feel, response and expression, which is good news for drummers!"
                ),
                new VideoSectionModel(
                    "https://www.youtube-nocookie.com/embed/gbtDe3fdUSY"
                ),
                new ParagraphSectionModel(
                    "Whether you are new to drums or you’re an experienced player, the TOURTECH TT-16S provides an absorbing, high quality experience with plenty of player-friendly features and excellent sounds available. There are features here to make recording drums a breeze and there are features here to make jamming away on your kit both fun and rewarding."
                ),
                new ParagraphSectionModel(
                    "The frame (or ‘rack’) of the TT-16S is larger than the TT-12 models but is still eminently compact and portable. This kit sets up quickly and easily out of the box: the main rack is already built which is a time saver!"
                ),
                new ImageSectionModel(
                    new ImageModel("Playing TOURTECH drums", "Product/Lifestyle/TOURTECH-drums-7.jpg")
                ),
                new ParagraphSectionModel(
                    "Once you’re set up and ready to go, you’ll find plenty of fun within the TT-16 module. There are over 450 top quality samples on board that span a range of styles and types. These are arranged into 26 complete preset kits: there are also 15 kits that can be edited to your own preference."
                ),
                new ParagraphSectionModel(
                    "Jam along to 20 built in demo songs or take advantage of the unit’s Aux-in jack to connect your music playing device (phone, mp3 player etc) and play along with your favourite songs."
                ),
                new ParagraphSectionModel(
                    "When you start playing, you’re notice the upgraded, fully responsive drum and cymbal pads. Each pad has ‘Dual Zone’ technology to allow multiple sounds from the same pad: snare can have ‘rimshot’ sounds, for example. Cymbals can also be ‘choked’ by hand for an altogether more realistic playing experience."
                ),
                new ImageSectionModel(
                    new ImageModel("Playing two TOURTECH drum kits", "Product/Lifestyle/TOURTECH-drums-8.jpg")
                ),
                new ParagraphSectionModel(
                    "USB and MIDI connectivity is included to increase functionality significantly. Trigger separate outboard devices with your drums and record entire tracks of drums to your computer, all stereo panned as they are in your headphones!"
                ),
                new ParagraphSectionModel(
                    "Extra enhanced functions include a 3 band EQ section, two different reverb settings and editable drum sounds."
                ),
                new ParagraphSectionModel(
                    "This TOURTECH TT-16S electric drum kit is a sophisticated unit full of pro-level features at a fantastically low price. Learning on a quality kit like this encourages you to play more and it’s also lots of fun! Recording sessions will also be a lot easier and more professional sounding with a digital kit like this: you can achieve a natural performance rather than a stiff, programmed one. All in all, there is something for every drummer with the great value TOURTECH TT-16S."
                ),
            }, 
            new ImageModel[] {
                new ImageModel("TT-16S electronic drum kit", "Product/TT-16S-drums-gallery-1.jpg"),
                new ImageModel("TT-16S drum pads", "Product/TT-16S-drums-gallery-2.jpg"),
                new ImageModel("TT-16S digital control panel", "Product/TT-16S-drums-gallery-3.jpg"),
                new ImageModel("TT-16S kick pedal", "Product/TT-16S-drums-gallery-4.jpg"),
            },
            new string[] { }, new string[] {
                "Complete 8-Piece Electric Drum Kit",
                "3-Sided, ergonomic rack system",
                "128 x 64 character LCD display",
                "458 high quality percussion voices",
                "26 preset drum kits + 15 user-defined drums kits",
                "20 demo songs",
                "Fully responsive, dual zone tom and cymbal pads",
                "Ride and Crash cymbals with \"choke\" function",
                "Dual zone snare pad with rim-shot and cross-stick feature",
                "Built-in demo tracks and record facility",
                "Click Track / Metronome function",
                "MP3 connectivity via Aux-input",
                "Fully expandable with extra tom and cymbal inputs",
                "MIDI In / Out and USB Connectivity",
                "Editable drum sounds, featuring \"tune\" function",
                "3 band EQ, 3 ambience and 2 reverb settings",
                "Upright and fully responsive bass drum trigger",
                "Complete with bass drum pedal and sticks"
            },
            new MetaDataModel(
                "TOURTECH TT-16S – Pro Featured Electric Drum, Entry Level Price",
                "TOURTECH’s flagship kit has professional specs including full mesh heads and USB connectivity. Enjoy all of these upgrades at an astounding price point."
            )
        );

        private static CategoryModel[] categories = new CategoryModel[]
        {
            new CategoryModel(
                "drum-kits", "Drum Kits", "Category/product-drums.jpg", "Banners/drums.jpg", false,
                new ProductModel[] { tt12s, tt22m, tt12sm, tt16s },
                new ContentSectionModel[] {
                    new VideoSectionModel(
                        "https://www.youtube-nocookie.com/embed/gbtDe3fdUSY"
                    ),
                    new CompositeSectionModel(
                        "Drum Kits", 
                        new string[] {
                            "You’ve always wanted to play the drums. You drum with your fingers on the kitchen table, on the car steering wheel, at work... there’s a beat to everything and you constantly feel it.",
                            "You’ve wanted drums for as long as you can remember but you’ve never just gone out and bought yourself a set. There has always been a reason: your neighbours and family wouldn’t like the noise, you don’t have a spare entire room to devote to a drum kit, you think it’ll work out to be too expensive...",
                            "Well, TOURTECH is here to change all of these false suppositions. TOURTECH have produced a range of digital drum kits to ignite the fire of excitement within you and get you playing drums!",
                            "The TOURTECH range is portable, easy to set up and lots of fun to play! There are four models and each takes up a smaller space than you may imagine. These kits can fit into much tighter spaces than acoustic drum kits, making them a great fit for bedrooms and studies."
                        }, 
                        new ImageModel("Playing TOURTECH drums", "Category/TOURTECH-drums-1.jpg"), 
                        RelativeDirection.Right 
                    )
                },
                new MetaDataModel(
                    "TOURTECH Drum Kits: Play, Practise and Record Anywhere",
                    "TOURTECH electronic drums let you play what you want, when you want. Affordable, quality digital kits that fit into your life."
                )
            ),
            new CategoryModel(
                "cables", "Cables", "Category/product-cables.jpg", "Banners/cables.jpg", false,
                new ProductModel[] { },
                new ContentSectionModel[] {
                    new ParagraphSectionModel(
                        "TOURTECH cables are here for every eventuality you'll find on the road. We test every cable design to ensure high performance and reliability. TOURTECH have a cable for every musical situation and application. Guitarists, vocalists and producers will find the connections they need with TOURTECH."
                    ),
                    new ParagraphSectionModel(
                        "All our cables have flexible outer jacketing and quality shielding for quality and reliability."
                    ),
                    new ParagraphSectionModel(
                        "Musicians can take advantage of our instrument cables. We offer straight and angled jacks with cable lengths ranging from 4 inches to 6 metres. Producers will find every connector they need for their studio productions. DJs are covered for their live sets."
                    ),
                    new ParagraphSectionModel(
                        "Don't just buy replacement cables: choose cables that have been proven on the road. Choose TOURTECH."
                    ),
                    new CompositeSectionModel(
                        "Instrument Cables",
                        new string[] {
                            "TOURTECH instrument cables are your reliable choice for the studio, rehearsal room and stage. These high-quality cables are shielded and feature high end jack connectors to ensure your tone is strong and noise-free.",
                            "TOURTECH cables are available in a variety of popular lengths with both straight and angled jack ends. Whatever you play and wherever you play, make sure you take TOURTECH cables with you."
                        },
                        new ImageModel("Instrument Cable", "Category/instru-cable.jpg"),
                        RelativeDirection.Right
                    ),
                    new CompositeSectionModel(
                        "Microphone Cables",
                        new string[] {
                            "TOURTECH microphone cables are the choice for gigging professionals everywhere. Our cables are shielded to reduce unwanted noise and have quality XLR connectors. These balanced cables will keep your signal strong and clear, exactly as it should be.",
                            "TOURTECH microphone cables are available in a variety of lengths. Find your perfect microphone cable with TOURTECH."
                        },
                        new ImageModel("Microphone Cable", "Category/mic-cable.jpg"),
                        RelativeDirection.Left
                    ),
                    new CompositeSectionModel(
                        "Audio Cables",
                        new string[] {
                            "TOURTECH audio cables provide a quality and comprehensive range of solutions for the modern producer. Every type and permutation of connector is provided to allow you to make stress-free connections. Bring your studio equipment to life with our quality cabling.",
                            "DJs will also find everything they need to hook up their gear for live sets. TOURTECH has a cabling solution for every musician and music-maker.",
                            "If you make music, make it with TOURTECH."
                        },
                        new ImageModel("Audio Cable", "Category/audio-cable.jpg"),
                        RelativeDirection.Right
                    )
                },
                new MetaDataModel(
                    "TOURTECH Cables: Your First Choice from Studio to Stage.",
                    "TOURTECH bring their road-tested expertise to a series of quality instrument cables."
                )
            ),
            new CategoryModel(
                "stands-stools", "Stands & Stools", "Category/product-stands.jpg", "Banners/stands.jpg", false, 
                new ProductModel[] { }, 
                new ContentSectionModel[] {
                    new ParagraphSectionModel(
                        "TOURTECH stands and stools allow you to perform confidently and creatively night after night. The keywords with TOURTECH stands and stools are simplicity, reliability and consistency. You want to enjoy giving your audiences a performance they’ll never forget. TOURTECH is here to play our part with gear you can rely on to take the punishment of a tour in its stride."
                    ),
                    new ParagraphSectionModel(
                        "Heavy duty yet light weight, our stands will keep your guitars and keyboards where they are supposed to be, ready for action."
                    ),
                    new ParagraphSectionModel(
                        "Out tour-tested benches and stools will stand up to the pressures of life on the road, allowing you to concentrate on what’s most important: music."
                    ),
                    new CompositeSectionModel(
                        "Instrument Stands",
                        new string[] {
                            "The TOURTECH range of instrument stands have been tested and tested again across the world’s venues to ensure reliability.",
                            "Our instrument stands are custom designed to securely cradle your guitar, bass, keyboard or amp. TOURTECH make stands you can trust. We use light weight but heavy duty materials to produce stands that are tough enough for a life of modern touring.",
                            "TOURTECH wall hangers are simple to fit and are perfect for keeping your instruments neatly and safely off the floor.",
                            "Gigging musicians don’t leave home without TOURTECH stands.",
                        },
                        new ImageModel("TOURTECH instrument stands", "Product/instrument-stands.jpg"),
                        RelativeDirection.Right
                    ),
                    new CompositeSectionModel(
                        "Pro Audio Stands",
                        new string[] {
                            "TOURTECH’s ethos of making tough, durable products for touring musicians continues with our range of Pro Audio stands. From simple yet effective sheet music stands to heavy duty tripod stands for PA speakers, TOURTECH has every stand you need to conduct your tour successfully.",
                            "Producers and studio musicians love our reliable monitor stands whilst vocalists swear by our gig-proof boom microphone stands. Performers everywhere use TOURTECH tablet stands for live performances.",
                            "TOURTECH stands: we are here for you when and where you need us most.",
                        },
                        new ImageModel("TOURTECH pro audio stands", "Product/pro-audio-stands.jpg"),
                        RelativeDirection.Left
                    )
                },
                new MetaDataModel(
                    "TOURTECH Stands: Trust Your Instrument With Nothing Else",
                    "TOURTECH stands are made to stand the test of a tour. TOURTECH instrument stands are durable, heavy-duty and reliable."
                )
            ),
            new CategoryModel(
                "bags-cases", "Bags & Cases", "Category/product-cases.jpg", "Banners/cases.jpg", false, 
                new ProductModel[] { }, 
                new ContentSectionModel[] {
                    new ParagraphSectionModel(
                        "TOURTECH have designed a range of cases and bags that are tough and reliable for a life on the road. This range includes durable soft cases & gig bags as well as rugged cases for both instruments & pro audio equipment."
                    ),
                    new ParagraphSectionModel(
                        "Our aggressive road testing policy ensures that every TOURTECH bag and case excels in quality and performance."
                    ),
                    new ParagraphSectionModel(
                        "Protect your guitars, keyboards and rack equipment with a range of products that are set for the long haul. Choose TOURTECH when you head out on the road."
                    ),
                    new CompositeSectionModel(
                        "Instrument Cases",
                        new string[] {
                            "We use tough materials for our TOURTECH instrument cases. We make our outer shells from moulded ABS plastic, padded with high density foam inside. This provides excellent shock absorption and keeps the weight light and manageable.",
                            "Our cases have chrome latches for decades of use and large moulded handles for comfort.",
                            "TOURTECH instrument cases are available in a comprehensive variety of popular shapes. Trust TOURTECH to protect your prized instruments."
                        },
                        new ImageModel("TOURTECH instrument case", "Product/hard-case.jpg"),
                        RelativeDirection.Right
                    ),
                    new CompositeSectionModel(
                        "Instrument Bags",
                        new string[] {
                            "TOURTECH instrument bags are available in a several ranges: Standard, Deluxe and Premium. Each TOURTECH bag is made from water repellant nylon and has up to 20mm of padding.",
                            "Adjustable, reinforced shoulder straps make carrying your guitar, bass or keyboard easy. A plethora of outer pouches on every bag are useful for carrying accessories.",
                            "These tough wearing bags are ideal for safely transporting your instruments. Modern musicians need to be mobile: TOURTECH recognises this and delivers the tools you need."
                        },
                        new ImageModel("TOURTECH instrument bag", "Product/bags.jpg"),
                        RelativeDirection.Left
                    )
                },
                new MetaDataModel(
                    "TOURTECH Bags and Cases: Strength Where You Need It Most",
                    "Protect your instrument with a heavy-duty bag or case from TOURTECH. Tough and uncompromising, these will let you carry your guitar, bass or keyboard in style."
                )
            ),
            new CategoryModel(
                "accessories", "Accessories", "Category/product-accessories.jpg", "Banners/accessories.jpg", false, 
                new ProductModel[] { }, 
                new ContentSectionModel[] {

                    new ParagraphSectionModel(
                        "TOURTECH accessories are designed to give you what you need, when you need it. Our range of accessories are made with the performing musician in mind."
                    ),
                    new ParagraphSectionModel(
                        "TOURTECH accessories include a range of clip-on tuners, capos and power supplies."
                    ),
                    new ParagraphSectionModel(
                        "Our tuners are accurate, highly portable and have bright screens to ensure easy visibility on dark stages. Our tuners clip on to your instrument’s headstock for easy use."
                    ),
                    new ParagraphSectionModel(
                        "Our quality power supply units are the perfect choice for any gigging musician’s case or spares bag. Make sure the show happens smoothly by keeping a TOURTECH power supply handy for emergencies."
                    ),
                    new ParagraphSectionModel(
                        "Load up on quality touring essentials with TOURTECH accessories."
                    ),
                    new CompositeSectionModel(
                        "Capos",
                        new string[] {
                            "TOURTECH capos have an innovative quick-release mechanism for easy one-handed operation. These capos will fit all standard electric and acoustic guitars as well as many folk instruments.",
                        },
                        new ImageModel("Capos", "Product/capos.jpg"),
                        RelativeDirection.Right
                    ),
                    new CompositeSectionModel(
                        "Tuners",
                        new string[] {
                            "TOURTECH clip on tuners are an essential addition to every musician’s gig bag. Whether you play guitar or bass, electric or acoustic, our tuners will attach to the instrument’s headstock easily and subtly.",
                            "A bright display screen on all tuner models allows great visibility on dark stages.",
                            "Every TOURTECH tuner design is chromatic. This means that altered tunings, drop tunings and open tunings are easily recognised by the tuner. No matter how you prefer to tune your guitar, TOURTECH clip on tuners have your back.",
                            "TOURTECH clip on tuners can also be used with other stringed instruments like violins, ukuleles and mandolins.",
                            "Keep your music sounding correct and in tune with TOURTECH clip on tuners."
                        },
                        new ImageModel("Tuners", "Product/tuners.jpg"),
                        RelativeDirection.Left
                    ),
                    new CompositeSectionModel(
                        "Power Supplies",
                        new string[] {
                            "TOURTECH power supplies are designed to offer reliable and constant power to your pedals and devices.",
                            "Whether as a safety measure or a replacement, keeping a spare power supply handy is a touring fundamental. At TOURTECH, we realise the need for an affordable, accessible power supply.",
                            "Every gig bag should have one. TOURTECH is here to make sure every performance is smooth and professional. TOURTECH power supplies ensure that the show will always go on.",
                        },
                        new ImageModel("Power Supplies", "Product/power-supply.jpg"),
                        RelativeDirection.Right
                    )
                },
                new MetaDataModel(
                    "TOURTECH Accessories: Don’t Leave Home Without Them",
                    "TOURTECH’s line of accessories, including Caps, clip-on tuners and powers supplies, allow you to stock up of the tools you need for your next incredible show."
                )
            )
        };

        public IEnumerable<CategoryModel> GetCategories()
        {
            return categories;
        }

        public CategoryModel GetCategory(string categoryName)
        {
            try
            {
                return categories.Single(a => a.Name == categoryName);
            }
            catch(InvalidOperationException)
            {
                throw new ClientException();
            }
        }

        public CategoryModel GetCategoryByProduct(string productName)
        {
            try
            {
                return categories.Single(a => a.Products.Any(b => b.Name == productName));
            }
            catch (InvalidOperationException)
            {
                throw new ClientException();
            }
        }

        public IEnumerable<ProductModel> GetProducts()
        {
            return categories.SelectMany(a => a.Products);
        }
    }
}
