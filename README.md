# Jellyfin Trickplay Complete

Jellyfin 10.11.11 plugin that finds videos eligible for Trickplay but missing one or more configured resolutions, then generates only the missing (ItemId, Width) entries.

## Build

The repository is pinned to Jellyfin 10.11.11 and .NET 9. GitHub Actions builds the Release DLL and publishes it as the trickplay-complete workflow artifact.

## Install

Download the workflow artifact, extract the DLL into Jellyfin's plugin directory under a folder such as TrickplayComplete_0.1.0.0, then restart Jellyfin. In Scheduled Tasks, run Complete Missing Trickplay.

The plugin follows Jellyfin's current Trickplay width, interval, tile, quality and SaveTrickplayWithMedia settings. Plugin-only limits are concurrency, FFmpeg threads, tolerant extraction, maximum frames, timeout, temporary space and retry records.

## Safety

The task scans metadata and existing Trickplay records before starting FFmpeg. It never modifies source media or writes jellyfin.db directly. It validates JPEG output and tile output, saves native Trickplay metadata only after successful generation, terminates FFmpeg process trees on cancellation/timeout, and removes temporary files.