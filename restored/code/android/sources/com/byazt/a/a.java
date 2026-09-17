package com.byazt.a;

import android.content.Context;
import android.content.Intent;
import com.bykv.vk.component.ttvideo.player.C;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 34, 34})
public class a extends c {
    public a(Context context) {
        super(context, null, null);
    }

    @Override // com.byazt.a.n
    public Intent tt() {
        Intent intent = new Intent("android.settings.SECURITY_SETTINGS");
        intent.addFlags(C.ENCODING_PCM_MU_LAW);
        intent.addFlags(1073741824);
        intent.addFlags(8388608);
        return intent;
    }
}
