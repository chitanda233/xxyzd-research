package com.byazt.afw;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_NATIVE_YV12_RENDER, 54})
public class ve implements uj {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public long f665a;
    public long c;
    public long n;
    public int sp;
    public long tt;
    public int uj;
    public int ve;

    public void c(long j) {
        this.f665a = j;
    }

    public void c(int i) {
        this.sp = i;
    }

    public void tt(long j) {
        this.n = j;
    }

    public void ve(long j) {
        this.c = j;
    }

    public void uj(long j) {
        this.tt = j;
    }

    public void tt(int i) {
        this.ve = i;
    }

    public void ve(int i) {
        this.uj = i;
    }

    @Override // com.byazt.afw.uj
    public void a_(JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        try {
            jSONObject.put("buffers_time", this.c);
            jSONObject.put("total_duration", this.tt);
            jSONObject.put("vbtt_skip_type", this.ve);
            jSONObject.put("skip_reason", this.uj);
            jSONObject.put("video_cache_size", this.n);
            jSONObject.put("current", this.f665a);
            jSONObject.put("percent", this.sp);
        } catch (Throwable th) {
            com.byazt.nr.m.c(th);
        }
    }
}
