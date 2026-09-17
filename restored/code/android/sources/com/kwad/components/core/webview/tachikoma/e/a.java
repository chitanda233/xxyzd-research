package com.kwad.components.core.webview.tachikoma.e;

import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private List<Integer> auV;
    private final List<Integer> auW;

    /* synthetic */ a(byte b) {
        this();
    }

    private a() {
        this.auV = new ArrayList();
        this.auW = Arrays.asList(123, Integer.valueOf(MediaPlayer.MEDIA_PLAYER_OPTION_HW_CONTROL_BY_OPPO), Integer.valueOf(MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_SOLOPLAY), Integer.valueOf(MediaPlayer.MEDIA_PLAYER_OPTION_SLOW_PLAY_TIME), Integer.valueOf(MediaPlayer.MEDIA_PLAYER_OPTION_SKIP_AUDIO_GRAPH), 200);
    }

    /* JADX INFO: renamed from: com.kwad.components.core.webview.tachikoma.e.a$a, reason: collision with other inner class name */
    static class C0473a {
        private static final a ava = new a(0);
    }

    public static a zM() {
        return C0473a.ava;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void ca(int i) {
        if (this.auW.contains(Integer.valueOf(i))) {
            this.auV.add(Integer.valueOf(i));
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void bO(String str) {
        int iOptInt;
        try {
            iOptInt = new JSONObject(str).optInt("elementType");
        } catch (Exception unused) {
            iOptInt = Integer.MAX_VALUE;
        }
        if (this.auW.contains(Integer.valueOf(iOptInt))) {
            this.auV.add(Integer.valueOf(iOptInt));
        }
    }

    public final void cb(final int i) {
        by.runOnUiThread(new bi() { // from class: com.kwad.components.core.webview.tachikoma.e.a.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                a.this.ca(i);
            }
        });
    }

    public final void bP(final String str) {
        if (TextUtils.isEmpty(str)) {
            return;
        }
        by.runOnUiThread(new bi() { // from class: com.kwad.components.core.webview.tachikoma.e.a.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                a.this.bO(str);
            }
        });
    }

    public final List<Integer> zN() {
        return this.auV;
    }

    public final void zO() {
        this.auV.clear();
    }
}
