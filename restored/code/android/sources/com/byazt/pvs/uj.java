package com.byazt.pvs;

import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_DOLBY_PRESENTATION_ID, 15})
public class uj {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public int f1338a;
    public String c;
    public JSONObject n;
    public String tt;
    public int uj;
    public boolean ve;

    public uj(String str, String str2, boolean z, int i, JSONObject jSONObject, int i2) {
        this.c = str;
        this.tt = str2;
        this.ve = z;
        this.uj = i;
        this.n = jSONObject;
        this.f1338a = i2;
    }

    public JSONObject c() {
        if (this.n == null) {
            this.n = new JSONObject();
        }
        return this.n;
    }

    public String tt() {
        return this.c;
    }

    public String ve() {
        return this.tt;
    }

    public boolean uj() {
        return this.ve;
    }

    public int n() {
        return this.uj;
    }

    public void c(int i) {
        this.uj = i;
    }
}
