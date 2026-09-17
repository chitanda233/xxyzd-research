package com.byazt.a;

import android.content.Context;
import android.content.Intent;
import com.bykv.vk.component.ttvideo.player.C;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 34, 91})
public class sp extends c {
    public sp(Context context, com.byazt.k.c cVar, String str) {
        super(context, cVar, str);
    }

    @Override // com.byazt.a.n
    public Intent tt() {
        Intent intent = new Intent(com.byazt.ev.n.ve + ".filemanager.intent.action.BROWSER_FILE");
        intent.putExtra("CurrentDir", this.ve);
        intent.putExtra("CurrentMode", 1);
        intent.addFlags(C.ENCODING_PCM_MU_LAW);
        intent.addFlags(32768);
        intent.addFlags(1073741824);
        return intent;
    }
}
