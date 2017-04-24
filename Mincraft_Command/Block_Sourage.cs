﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mincraft_Command
{
    public class Block_Sourage
    {

        public static void Auto(TextBox t1)
        {
            var Source_Block = new AutoCompleteStringCollection();
            Source_Block.AddRange(new string[] {
                "minecraft:acacia_door",
                "minecraft:acacia_fence",
                "minecraft:acacia_fence_gate",
                "minecraft:acacia_stairs",
                "minecraft:activator_rail",
                "minecraft:air",
                "minecraft:anvil",
                "minecraft:barrier",
                "minecraft:beacon",
                "minecraft:bed",
                "minecraft:bedrock",
                "minecraft:beetroots",
                "minecraft:birch_door",
                "minecraft:birch_fence",
                "minecraft:birch_fence_gate",
                "minecraft:birch_stairs",
                "minecraft:black_shulker_box",
                "minecraft:blue_shulker_box",
                "minecraft:bone_block",
                "minecraft:bookshelf",
                "minecraft:brewing_stand",
                "minecraft:brick_block",
                "minecraft:brick_stairs",
                "minecraft:brown_mushroom",
                "minecraft:brown_mushroom_block",
                "minecraft:brown_shulker_box",
                "minecraft:cactus",
                "minecraft:cake",
                "minecraft:carpet",
                "minecraft:carrots",
                "minecraft:cauldron",
                "minecraft:chain_command_block",
                "minecraft:chest",
                "minecraft:chorus_flower",
                "minecraft:chorus_plant",
                "minecraft:clay",
                "minecraft:coal_block",
                "minecraft:coal_ore",
                "minecraft:cobblestone",
                "minecraft:cobblestone_wall",
                "minecraft:cocoa",
                "minecraft:command_block",
                "minecraft:crafting_table",
                "minecraft:cyan_shulker_box",
                "minecraft:dark_oak_door",
                "minecraft:dark_oak_fence",
                "minecraft:dark_oak_fence_gate",
                "minecraft:dark_oak_stairs",
                "minecraft:daylight_detector",
                "minecraft:daylight_detector_inverted",
                "minecraft:deadbush",
                "minecraft:detector_rail",
                "minecraft:diamond_block",
                "minecraft:diamond_ore",
                "minecraft:dirt",
                "minecraft:dispenser",
                "minecraft:double_plant",
                "minecraft:double_stone_slab",
                "minecraft:double_stone_slab2",
                "minecraft:double_wooden_slab",
                "minecraft:dragon_egg",
                "minecraft:dropper",
                "minecraft:emerald_block",
                "minecraft:emerald_ore",
                "minecraft:enchanting_table",
                "minecraft:end_bricks",
                "minecraft:end_gateway",
                "minecraft:end_portal",
                "minecraft:end_portal_frame",
                "minecraft:end_rod",
                "minecraft:end_stone",
                "minecraft:ender_chest",
                "minecraft:farmland",
                "minecraft:fence",
                "minecraft:fence_gate",
                "minecraft:fire",
                "minecraft:flower_pot",
                "minecraft:flowing_lava",
                "minecraft:flowing_water",
                "minecraft:frosted_ice",
                "minecraft:furnace",
                "minecraft:glass",
                "minecraft:glass_pane",
                "minecraft:glowstone",
                "minecraft:gold_block",
                "minecraft:gold_ore",
                "minecraft:golden_rail",
                "minecraft:grass",
                "minecraft:grass_path",
                "minecraft:gravel",
                "minecraft:gray_shulker_box",
                "minecraft:green_shulker_box",
                "minecraft:hardened_clay",
                "minecraft:hay_block",
                "minecraft:heavy_weighted_pressure_plate",
                "minecraft:hopper",
                "minecraft:ice",
                "minecraft:iron_bars",
                "minecraft:iron_block",
                "minecraft:iron_door",
                "minecraft:iron_ore",
                "minecraft:iron_trapdoor",
                "minecraft:jukebox",
                "minecraft:jungle_door",
                "minecraft:jungle_fence",
                "minecraft:jungle_fence_gate",
                "minecraft:jungle_stairs",
                "minecraft:ladder",
                "minecraft:lapis_block",
                "minecraft:lapis_ore",
                "minecraft:lava",
                "minecraft:leaves",
                "minecraft:leaves2",
                "minecraft:lever",
                "minecraft:light_blue_shulker_box",
                "minecraft:light_weighted_pressure_plate",
                "minecraft:lime_shulker_box",
                "minecraft:lit_furnace",
                "minecraft:lit_pumpkin",
                "minecraft:lit_redstone_lamp",
                "minecraft:lit_redstone_ore",
                "minecraft:log",
                "minecraft:log2",
                "minecraft:magenta_shulker_box",
                "minecraft:magma",
                "minecraft:melon_block",
                "minecraft:melon_stem",
                "minecraft:mob_spawner",
                "minecraft:monster_egg",
                "minecraft:mossy_cobblestone",
                "minecraft:mycelium",
                "minecraft:nether_brick",
                "minecraft:nether_brick_fence",
                "minecraft:nether_brick_stairs",
                "minecraft:nether_wart",
                "minecraft:nether_wart_block",
                "minecraft:netherrack",
                "minecraft:noteblock",
                "minecraft:oak_stairs",
                "minecraft:observer",
                "minecraft:obsidian",
                "minecraft:orange_shulker_box",
                "minecraft:packed_ice",
                "minecraft:pink_shulker_box",
                "minecraft:piston",
                "minecraft:piston_extension",
                "minecraft:piston_head",
                "minecraft:planks",
                "minecraft:portal",
                "minecraft:potatoes",
                "minecraft:powered_comparator",
                "minecraft:powered_repeater",
                "minecraft:prismarine",
                "minecraft:pumpkin",
                "minecraft:pumpkin_stem",
                "minecraft:purple_shulker_box",
                "minecraft:purpur_block",
                "minecraft:purpur_double_slab",
                "minecraft:purpur_pillar",
                "minecraft:purpur_slab",
                "minecraft:purpur_stairs",
                "minecraft:quartz_block",
                "minecraft:quartz_ore",
                "minecraft:quartz_stairs",
                "minecraft:rail",
                "minecraft:red_flower",
                "minecraft:red_mushroom",
                "minecraft:red_mushroom_block",
                "minecraft:red_nether_brick",
                "minecraft:red_sandstone",
                "minecraft:red_sandstone_stairs",
                "minecraft:red_shulker_box",
                "minecraft:redstone_block",
                "minecraft:redstone_lamp",
                "minecraft:redstone_ore",
                "minecraft:redstone_torch",
                "minecraft:redstone_wire",
                "minecraft:reeds",
                "minecraft:repeating_command_block",
                "minecraft:sand",
                "minecraft:sandstone",
                "minecraft:sandstone_stairs",
                "minecraft:sapling",
                "minecraft:sea_lantern",
                "minecraft:silver_shulker_box",
                "minecraft:skull",
                "minecraft:slime",
                "minecraft:snow",
                "minecraft:snow_layer",
                "minecraft:soul_sand",
                "minecraft:sponge",
                "minecraft:spruce_door",
                "minecraft:spruce_fence",
                "minecraft:spruce_fence_gate",
                "minecraft:spruce_stairs",
                "minecraft:stained_glass",
                "minecraft:stained_glass_pane",
                "minecraft:stained_hardened_clay",
                "minecraft:standing_banner",
                "minecraft:standing_sign",
                "minecraft:sticky_piston",
                "minecraft:stone",
                "minecraft:stone_brick_stairs",
                "minecraft:stone_button",
                "minecraft:stone_pressure_plate",
                "minecraft:stone_slab",
                "minecraft:stone_slab2",
                "minecraft:stone_stairs",
                "minecraft:stonebrick",
                "minecraft:structure_block",
                "minecraft:structure_void",
                "minecraft:tallgrass",
                "minecraft:tnt",
                "minecraft:torch",
                "minecraft:trapdoor",
                "minecraft:trapped_chest",
                "minecraft:tripwire",
                "minecraft:tripwire_hook",
                "minecraft:unlit_redstone_torch",
                "minecraft:unpowered_comparator",
                "minecraft:unpowered_repeater",
                "minecraft:vine",
                "minecraft:wall_banner",
                "minecraft:wall_sign",
                "minecraft:water",
                "minecraft:waterlily",
                "minecraft:web",
                "minecraft:wheat",
                "minecraft:white_shulker_box",
                "minecraft:wooden_button",
                "minecraft:wooden_door",
                "minecraft:wooden_pressure_plate",
                "minecraft:wooden_slab",
                "minecraft:wool",
                "minecraft:yellow_flower",
                "minecraft:yellow_shulker_box",
                "acacia_door",
                "acacia_fence",
                "acacia_fence_gate",
                "acacia_stairs",
                "activator_rail",
                "air",
                "anvil",
                "barrier",
                "beacon",
                "bed",
                "bedrock",
                "beetroots",
                "birch_door",
                "birch_fence",
                "birch_fence_gate",
                "birch_stairs",
                "black_shulker_box",
                "blue_shulker_box",
                "bone_block",
                "bookshelf",
                "brewing_stand",
                "brick_block",
                "brick_stairs",
                "brown_mushroom",
                "brown_mushroom_block",
                "brown_shulker_box",
                "cactus",
                "cake",
                "carpet",
                "carrots",
                "cauldron",
                "chain_command_block",
                "chest",
                "chorus_flower",
                "chorus_plant",
                "clay",
                "coal_block",
                "coal_ore",
                "cobblestone",
                "cobblestone_wall",
                "cocoa",
                "command_block",
                "crafting_table",
                "cyan_shulker_box",
                "dark_oak_door",
                "dark_oak_fence",
                "dark_oak_fence_gate",
                "dark_oak_stairs",
                "daylight_detector",
                "daylight_detector_inverted",
                "deadbush",
                "detector_rail",
                "diamond_block",
                "diamond_ore",
                "dirt",
                "dispenser",
                "double_plant",
                "double_stone_slab",
                "double_stone_slab2",
                "double_wooden_slab",
                "dragon_egg",
                "dropper",
                "emerald_block",
                "emerald_ore",
                "enchanting_table",
                "end_bricks",
                "end_gateway",
                "end_portal",
                "end_portal_frame",
                "end_rod",
                "end_stone",
                "ender_chest",
                "farmland",
                "fence",
                "fence_gate",
                "fire",
                "flower_pot",
                "flowing_lava",
                "flowing_water",
                "frosted_ice",
                "furnace",
                "glass",
                "glass_pane",
                "glowstone",
                "gold_block",
                "gold_ore",
                "golden_rail",
                "grass",
                "grass_path",
                "gravel",
                "gray_shulker_box",
                "green_shulker_box",
                "hardened_clay",
                "hay_block",
                "heavy_weighted_pressure_plate",
                "hopper",
                "ice",
                "iron_bars",
                "iron_block",
                "iron_door",
                "iron_ore",
                "iron_trapdoor",
                "jukebox",
                "jungle_door",
                "jungle_fence",
                "jungle_fence_gate",
                "jungle_stairs",
                "ladder",
                "lapis_block",
                "lapis_ore",
                "lava",
                "leaves",
                "leaves2",
                "lever",
                "light_blue_shulker_box",
                "light_weighted_pressure_plate",
                "lime_shulker_box",
                "lit_furnace",
                "lit_pumpkin",
                "lit_redstone_lamp",
                "lit_redstone_ore",
                "log",
                "log2",
                "magenta_shulker_box",
                "magma",
                "melon_block",
                "melon_stem",
                "mob_spawner",
                "monster_egg",
                "mossy_cobblestone",
                "mycelium",
                "nether_brick",
                "nether_brick_fence",
                "nether_brick_stairs",
                "nether_wart",
                "nether_wart_block",
                "netherrack",
                "noteblock",
                "oak_stairs",
                "observer",
                "obsidian",
                "orange_shulker_box",
                "packed_ice",
                "pink_shulker_box",
                "piston",
                "piston_extension",
                "piston_head",
                "planks",
                "portal",
                "potatoes",
                "powered_comparator",
                "powered_repeater",
                "prismarine",
                "pumpkin",
                "pumpkin_stem",
                "purple_shulker_box",
                "purpur_block",
                "purpur_double_slab",
                "purpur_pillar",
                "purpur_slab",
                "purpur_stairs",
                "quartz_block",
                "quartz_ore",
                "quartz_stairs",
                "rail",
                "red_flower",
                "red_mushroom",
                "red_mushroom_block",
                "red_nether_brick",
                "red_sandstone",
                "red_sandstone_stairs",
                "red_shulker_box",
                "redstone_block",
                "redstone_lamp",
                "redstone_ore",
                "redstone_torch",
                "redstone_wire",
                "reeds",
                "repeating_command_block",
                "sand",
                "sandstone",
                "sandstone_stairs",
                "sapling",
                "sea_lantern",
                "silver_shulker_box",
                "skull",
                "slime",
                "snow",
                "snow_layer",
                "soul_sand",
                "sponge",
                "spruce_door",
                "spruce_fence",
                "spruce_fence_gate",
                "spruce_stairs",
                "stained_glass",
                "stained_glass_pane",
                "stained_hardened_clay",
                "standing_banner",
                "standing_sign",
                "sticky_piston",
                "stone",
                "stone_brick_stairs",
                "stone_button",
                "stone_pressure_plate",
                "stone_slab",
                "stone_slab2",
                "stone_stairs",
                "stonebrick",
                "structure_block",
                "structure_void",
                "tallgrass",
                "tnt",
                "torch",
                "trapdoor",
                "trapped_chest",
                "tripwire",
                "tripwire_hook",
                "unlit_redstone_torch",
                "unpowered_comparator",
                "unpowered_repeater",
                "vine",
                "wall_banner",
                "wall_sign",
                "water",
                "waterlily",
                "web",
                "wheat",
                "white_shulker_box",
                "wooden_button",
                "wooden_door",
                "wooden_pressure_plate",
                "wooden_slab",
                "wool",
                "yellow_flower",
                "yellow_shulker_box"
            });
            t1.AutoCompleteCustomSource = Source_Block;
            t1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            t1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
