package com.baidu.oauth.sdkbqt.a;

import android.content.Context;
import android.content.Intent;
import android.text.TextUtils;
import android.util.TypedValue;
import com.baidu.oauth.sdkbqt.auth.BdSsoHandler;
import com.byazt.nys.PluginConstants;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class i {
    public static int a(Context context, float f) {
        return (int) TypedValue.applyDimension(1, f, context.getResources().getDisplayMetrics());
    }

    public static Intent a(int i, String str) {
        Intent intent = new Intent();
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.put(PluginConstants.KEY_ERROR_CODE, i);
            if (!TextUtils.isEmpty(str)) {
                jSONObject.put("msg", str);
            }
        } catch (JSONException e) {
            d.a(e);
        }
        intent.putExtra(BdSsoHandler.EXTRA_OAUTH_RESULT_JSON, jSONObject.toString());
        return intent;
    }

    public static Intent a(int i) {
        return a(i, "");
    }
}
