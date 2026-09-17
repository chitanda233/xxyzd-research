package com.kwad.sdk.utils;

import android.content.Context;
import android.media.AudioAttributes;
import android.media.AudioFocusRequest;
import android.media.AudioManager;
import com.bykv.vk.component.ttvideo.player.MediaFormat;

/* JADX INFO: loaded from: classes3.dex */
public final class j {
    private AudioManager aZy;
    private AudioManager.OnAudioFocusChangeListener bou = new AudioManager.OnAudioFocusChangeListener() { // from class: com.kwad.sdk.utils.j.1
        @Override // android.media.AudioManager.OnAudioFocusChangeListener
        public final void onAudioFocusChange(final int i) {
            if (j.this.kx == null) {
                return;
            }
            by.postOnUiThread(new Runnable() { // from class: com.kwad.sdk.utils.j.1.1
                @Override // java.lang.Runnable
                public final void run() {
                    if (i < 0) {
                        j.this.kx.onAudioBeOccupied();
                    } else {
                        j.this.kx.onAudioBeReleased();
                    }
                }
            });
        }
    };
    private a kx;

    public interface a {
        void onAudioBeOccupied();

        void onAudioBeReleased();
    }

    public j(Context context) {
        this.aZy = (AudioManager) context.getSystemService(MediaFormat.KEY_AUDIO);
    }

    public final boolean UC() {
        try {
            return (this.bou == null || this.aZy == null || 1 != this.aZy.requestAudioFocus(UD())) ? false : true;
        } catch (Throwable unused) {
        }
    }

    private AudioFocusRequest UD() {
        return new AudioFocusRequest.Builder(2).setAudioAttributes(new AudioAttributes.Builder().setLegacyStreamType(3).setUsage(1).setContentType(2).build()).setAcceptsDelayedFocusGain(false).setOnAudioFocusChangeListener(this.bou).build();
    }

    public final void c(a aVar) {
        this.kx = aVar;
    }
}
