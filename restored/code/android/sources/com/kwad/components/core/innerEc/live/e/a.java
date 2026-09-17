package com.kwad.components.core.innerEc.live.e;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    public static boolean aQ(int i) {
        if (i == 607) {
            return true;
        }
        switch (i) {
            case MediaPlayer.MEDIA_PLAYER_OPTION_ABR_DOWNLOAD_VIDEO_BITRATE /* 601 */:
            case MediaPlayer.MEDIA_PLAYER_OPTION_VIDEO_DECODER_BUFLEN /* 602 */:
            case MediaPlayer.MEDIA_PLAYER_OPTION_AUDIO_DECODER_BUFLEN /* 603 */:
                return true;
            default:
                return false;
        }
    }

    public static boolean aR(int i) {
        return i == 60;
    }
}
