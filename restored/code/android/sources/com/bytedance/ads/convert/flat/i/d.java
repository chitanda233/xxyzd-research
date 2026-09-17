package com.bytedance.ads.convert.flat.i;

import android.content.Context;
import android.content.SharedPreferences;
import android.util.Log;
import com.byazt.tk.AdBaseConstants;
import com.bytedance.ads.convert.BDConvert;
import kotlin.jvm.internal.Intrinsics;

/* JADX INFO: loaded from: classes2.dex */
public final class d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final d f1704a = new d();

    public final c a(Context context) {
        Intrinsics.checkNotNullParameter(context, "context");
        SharedPreferences sharedPreferences = context.getSharedPreferences("sp_name_bd_convert_click_id", 0);
        f fVarValueOf = null;
        String string = sharedPreferences.getString(AdBaseConstants.MARKET_OPEN_CLICK_ID, null);
        String string2 = sharedPreferences.getString("click_id_source", null);
        String string3 = sharedPreferences.getString("click_id_nature", null);
        String string4 = sharedPreferences.getString("hume_channel_id", null);
        if (string2 != null) {
            try {
                fVarValueOf = f.valueOf(string2);
            } catch (IllegalArgumentException e) {
                e.printStackTrace();
            }
        }
        return new c(string, string3, string4, fVarValueOf);
    }

    public final void a(Context context, c info) {
        f fVarValueOf;
        Intrinsics.checkNotNullParameter(context, "context");
        Intrinsics.checkNotNullParameter(info, "info");
        boolean z = false;
        SharedPreferences sharedPreferences = context.getSharedPreferences("sp_name_bd_convert_click_id", 0);
        String strName = null;
        String string = sharedPreferences.getString("click_id_source", null);
        if (string == null) {
            fVarValueOf = null;
        } else {
            try {
                fVarValueOf = f.valueOf(string);
            } catch (IllegalArgumentException e) {
                e.printStackTrace();
                fVarValueOf = null;
            }
        }
        if (fVarValueOf != null) {
            int iOrdinal = fVarValueOf.ordinal();
            f fVar = info.e;
            Intrinsics.checkNotNull(fVar);
            if (iOrdinal <= fVar.ordinal()) {
                z = true;
            }
        }
        String msg = "saveByPriority: ignore:" + z + " old:" + string + " new:" + info.e;
        Intrinsics.checkNotNullParameter("Convert:ClickIdSPUtil", "tag");
        Intrinsics.checkNotNullParameter(msg, "msg");
        if (BDConvert.INSTANCE.getConfig().getEnableLog()) {
            Log.d("Convert:ClickIdSPUtil", msg);
        }
        if (z) {
            return;
        }
        SharedPreferences.Editor editorPutString = sharedPreferences.edit().putString(AdBaseConstants.MARKET_OPEN_CLICK_ID, info.b);
        f fVar2 = info.e;
        if (fVar2 != null) {
            Intrinsics.checkNotNull(fVar2);
            strName = fVar2.name();
        }
        editorPutString.putString("click_id_source", strName).putString("click_id_nature", info.c).putString("hume_channel_id", info.d).apply();
    }
}
