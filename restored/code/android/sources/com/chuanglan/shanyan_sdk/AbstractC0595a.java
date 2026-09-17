package com.chuanglan.shanyan_sdk;

import android.content.Context;
import android.content.Intent;
import com.chuanglan.shanyan_sdk.view.CTCCPrivacyProtocolActivity;
import com.chuanglan.shanyan_sdk.view.ShanYanOneKeyActivity;

/* JADX INFO: renamed from: com.chuanglan.shanyan_sdk.a, reason: case insensitive filesystem */
/* JADX INFO: loaded from: classes2.dex */
public abstract class AbstractC0595a {
    public static void a(Context context, long j, long j2, long j3) {
        Intent intent = new Intent(context, (Class<?>) ShanYanOneKeyActivity.class);
        intent.putExtra("beginTime", j);
        intent.putExtra("stepStartTime", j2);
        intent.putExtra("methodStartTime", j3);
        intent.setFlags(com.bykv.vk.component.ttvideo.player.C.ENCODING_PCM_MU_LAW);
        context.startActivity(intent);
    }

    public static void a(Context context, String str, String str2) {
        try {
            Intent intent = new Intent(context, (Class<?>) CTCCPrivacyProtocolActivity.class);
            intent.putExtra("url", str);
            intent.putExtra(com.alipay.sdk.m.c0.d.w, str2);
            intent.setFlags(com.bykv.vk.component.ttvideo.player.C.ENCODING_PCM_MU_LAW);
            context.startActivity(intent);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
