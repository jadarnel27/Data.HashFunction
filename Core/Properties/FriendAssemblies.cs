﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#if !NuGetDeploy
    [assembly: InternalsVisibleTo("System.Data.HashFunction.BernsteinHash, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b1ecec083ec498e8f20a2c5d1ab389b79f14463545ec7de7f2bfcf3aa179753dc29dde328af8a6f6dc70b40ff468588ccf25f611c245036676851c53ce1d6190a05d495649fdefed1e32c71408da25ddf25ded8c04d02d4ca0edc8af5ed90cf0440a846de1a6ecc19ca0fc09ec7b31c0820a3eb7b44b8d02a3809a3a01ff3cd3")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.BuzHash, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b1ecec083ec498e8f20a2c5d1ab389b79f14463545ec7de7f2bfcf3aa179753dc29dde328af8a6f6dc70b40ff468588ccf25f611c245036676851c53ce1d6190a05d495649fdefed1e32c71408da25ddf25ded8c04d02d4ca0edc8af5ed90cf0440a846de1a6ecc19ca0fc09ec7b31c0820a3eb7b44b8d02a3809a3a01ff3cd3")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.CityHash, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b1ecec083ec498e8f20a2c5d1ab389b79f14463545ec7de7f2bfcf3aa179753dc29dde328af8a6f6dc70b40ff468588ccf25f611c245036676851c53ce1d6190a05d495649fdefed1e32c71408da25ddf25ded8c04d02d4ca0edc8af5ed90cf0440a846de1a6ecc19ca0fc09ec7b31c0820a3eb7b44b8d02a3809a3a01ff3cd3")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.CRC, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b1ecec083ec498e8f20a2c5d1ab389b79f14463545ec7de7f2bfcf3aa179753dc29dde328af8a6f6dc70b40ff468588ccf25f611c245036676851c53ce1d6190a05d495649fdefed1e32c71408da25ddf25ded8c04d02d4ca0edc8af5ed90cf0440a846de1a6ecc19ca0fc09ec7b31c0820a3eb7b44b8d02a3809a3a01ff3cd3")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.ELF64, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b1ecec083ec498e8f20a2c5d1ab389b79f14463545ec7de7f2bfcf3aa179753dc29dde328af8a6f6dc70b40ff468588ccf25f611c245036676851c53ce1d6190a05d495649fdefed1e32c71408da25ddf25ded8c04d02d4ca0edc8af5ed90cf0440a846de1a6ecc19ca0fc09ec7b31c0820a3eb7b44b8d02a3809a3a01ff3cd3")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.FNV, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b1ecec083ec498e8f20a2c5d1ab389b79f14463545ec7de7f2bfcf3aa179753dc29dde328af8a6f6dc70b40ff468588ccf25f611c245036676851c53ce1d6190a05d495649fdefed1e32c71408da25ddf25ded8c04d02d4ca0edc8af5ed90cf0440a846de1a6ecc19ca0fc09ec7b31c0820a3eb7b44b8d02a3809a3a01ff3cd3")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.Jenkins, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b1ecec083ec498e8f20a2c5d1ab389b79f14463545ec7de7f2bfcf3aa179753dc29dde328af8a6f6dc70b40ff468588ccf25f611c245036676851c53ce1d6190a05d495649fdefed1e32c71408da25ddf25ded8c04d02d4ca0edc8af5ed90cf0440a846de1a6ecc19ca0fc09ec7b31c0820a3eb7b44b8d02a3809a3a01ff3cd3")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.MurmurHash, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b1ecec083ec498e8f20a2c5d1ab389b79f14463545ec7de7f2bfcf3aa179753dc29dde328af8a6f6dc70b40ff468588ccf25f611c245036676851c53ce1d6190a05d495649fdefed1e32c71408da25ddf25ded8c04d02d4ca0edc8af5ed90cf0440a846de1a6ecc19ca0fc09ec7b31c0820a3eb7b44b8d02a3809a3a01ff3cd3")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.Pearson, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b1ecec083ec498e8f20a2c5d1ab389b79f14463545ec7de7f2bfcf3aa179753dc29dde328af8a6f6dc70b40ff468588ccf25f611c245036676851c53ce1d6190a05d495649fdefed1e32c71408da25ddf25ded8c04d02d4ca0edc8af5ed90cf0440a846de1a6ecc19ca0fc09ec7b31c0820a3eb7b44b8d02a3809a3a01ff3cd3")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.SpookyHash, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b1ecec083ec498e8f20a2c5d1ab389b79f14463545ec7de7f2bfcf3aa179753dc29dde328af8a6f6dc70b40ff468588ccf25f611c245036676851c53ce1d6190a05d495649fdefed1e32c71408da25ddf25ded8c04d02d4ca0edc8af5ed90cf0440a846de1a6ecc19ca0fc09ec7b31c0820a3eb7b44b8d02a3809a3a01ff3cd3")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.Test, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b1ecec083ec498e8f20a2c5d1ab389b79f14463545ec7de7f2bfcf3aa179753dc29dde328af8a6f6dc70b40ff468588ccf25f611c245036676851c53ce1d6190a05d495649fdefed1e32c71408da25ddf25ded8c04d02d4ca0edc8af5ed90cf0440a846de1a6ecc19ca0fc09ec7b31c0820a3eb7b44b8d02a3809a3a01ff3cd3")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.xxHash, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b1ecec083ec498e8f20a2c5d1ab389b79f14463545ec7de7f2bfcf3aa179753dc29dde328af8a6f6dc70b40ff468588ccf25f611c245036676851c53ce1d6190a05d495649fdefed1e32c71408da25ddf25ded8c04d02d4ca0edc8af5ed90cf0440a846de1a6ecc19ca0fc09ec7b31c0820a3eb7b44b8d02a3809a3a01ff3cd3")]
#else
    [assembly: InternalsVisibleTo("System.Data.HashFunction.BernsteinHash, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.BuzHash, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.CityHash, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.CRC, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.ELF64, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.FNV, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.Jenkins, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.MurmurHash, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.Pearson, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.SpookyHash, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.Test, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
    [assembly: InternalsVisibleTo("System.Data.HashFunction.xxHash, PublicKey=002400000480000094000000060200000024000052534131000400000100010085f076d56d0e4c1461db01820a06d1814c38d171cebad2714bf251a15ad82214fa3c51cd0c76e26265b4e46f96dd5ab5c9843b7406815d301bea7d7904c61c21ac54f4921b95a79443d801eeda3ffd6d32c3f458f73babb09a22d06f303dfd1afbb6e27eecffd072c8fe17c669d666b954c8a423ea9b4a9313691daf942a74b1")]
#endif