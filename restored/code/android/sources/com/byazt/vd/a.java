package com.byazt.vd;

import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.player.MediaFormat;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 1582, 34})
public class a extends c {
    public a(com.byazt.xj.ve veVar, String str, com.byazt.pm.a.c cVar) {
        super(veVar, str, cVar);
    }

    @Override // com.byazt.vd.c
    public void c() {
        if (this.f1507a == null || this.f1507a.size() <= 0) {
            return;
        }
        Object obj = this.f1507a.get("id");
        if (obj == null) {
            c(this.ve);
            return;
        }
        String strValueOf = String.valueOf(obj);
        if (TextUtils.isEmpty(strValueOf)) {
            c(this.ve);
            return;
        }
        com.byazt.xj.ve veVarTt = this.ve.tt(this.ve);
        if (veVarTt == null) {
            return;
        }
        c(veVarTt.uj(strValueOf));
    }

    private void c(com.byazt.xj.ve veVar) {
        Object obj;
        if (veVar == null) {
            return;
        }
        for (String str : this.f1507a.keySet()) {
            if (!TextUtils.isEmpty(str) && !TextUtils.equals(str, "id") && (obj = this.f1507a.get(str)) != null) {
                veVar.c(str, String.valueOf(obj));
            }
        }
        veVar.c(this.f1507a.containsKey(MediaFormat.KEY_WIDTH), this.f1507a.containsKey(MediaFormat.KEY_HEIGHT));
        veVar.tt();
    }
}
