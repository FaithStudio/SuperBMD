# SuperBMD
A library to import and export various 3D model formats into the Binary Model (BMD) format.

This API uses the Open Asset Import Library (AssImp). A list of supported model formats can be found [here](http://assimp.org/main_features_formats.html).

# Usage

SuperBMD.exe can be used to convert models to the BMD/BDL formats, or to convert BMD/BDL models to the DAE format.

The program must be run via the command line. Some example commands are below:

`SuperBMD.exe -i <in BMD path> -o <out DAE path>`

`SuperBMD.exe -i <in model path> -o <out BDL path> -x <path to tex_headers.json> -m <path to materials.json> --tristrip all --bdl`

## Notes
### Modeling
* When exporting a model for conversion to BMD, rotate the model about the X axis by -90 degrees. Most modeling programs define the Z axis as the up axis, but Nintendo games use the Y axis instead. Rotating the model ensures that the model is not sideways when imported into a game.

### Skinning
* SuperBMD supports both skinned and unskinned models.
* For skinned meshes, <b>make the root of the model's skeleton the child of a dummy object called `skeleton_root`.</b> SuperBMD uses the name of this dummy object to find the root of the skeleton so that it can process it.
* If a `skeleton_root` object is not found, then the model will be imported with a single root bone. This is recommended for models intended for maps.

### Vertex Colors
* SuperBMD supports vertex colors.

### Textures
* SuperBMD supports models that have no textures. These models will appear white when imported into a game.
* It is recommended that the model's textures be in the same directory as the model being converted. <b>If SuperBMD cannot find the model's textures, it will use a black and white checkerboard image instead.</b>
* Textures must be in either BMP, JPG, or PNG format. TGA is currently not supported.
