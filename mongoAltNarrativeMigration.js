//use AltNarrative

const genRanHex = size => [...Array(size)].map(() => Math.floor(Math.random() * 16).toString(16)).join("");
const rootNodeId = genRanHex(24);
const childNode1 = genRanHex(24);
const childNode2 = genRanHex(24);
const childNode3 = genRanHex(24);
const nodes = [{     
    "_id" :ObjectId(rootNodeId), 
    "title" : "Root Node Title", 
    "text" : "First bit of story", 
    "createdAt" : ISODate(new Date().toISOString()), 
    "updatedAt" :Timestamp(new Date().valueOf(), new Date().valueOf()),
    "childNodeIds":[ObjectId(childNode1), ObjectId(childNode2), ObjectId(childNode3)],
	"parentNodeId":null,
},{     
    "_id" :ObjectId(childNode1), 
    "title" : "childNode1 Title", 
    "text" : "childNode1 bit of story", 
    "createdAt" : ISODate(new Date().toISOString()), 
    "updatedAt" :Timestamp(new Date().valueOf(), new Date().valueOf()),
    "childNodeIds":null,
	"parentNodeId":ObjectId(rootNodeId),
},{     
    "_id" :ObjectId(childNode2), 
    "title" : "childNode2 Title", 
    "text" : "childNode2 bit of story", 
    "createdAt" : ISODate(new Date().toISOString()), 
    "updatedAt" :Timestamp(new Date().valueOf(), new Date().valueOf()),
    "childNodeIds":null,
	"parentNodeId":ObjectId(rootNodeId),
},{     
    "_id" :ObjectId(childNode3), 
    "title" : "childNode3 Title", 
    "text" : "childNode3 bit of story", 
    "createdAt" : ISODate(new Date().toISOString()), 
    "updatedAt" :Timestamp(new Date().valueOf(), new Date().valueOf()),
    "childNodeIds":null,
	"parentNodeId":ObjectId(rootNodeId),
}

];


db.text_nodes.insert( nodes );

