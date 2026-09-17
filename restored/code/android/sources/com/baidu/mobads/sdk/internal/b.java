package com.baidu.mobads.sdk.internal;

import android.text.TextUtils;
import com.sigmob.sdk.base.models.ClickCommon;
import java.util.ArrayList;
import java.util.List;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private int f431a = 0;
    private List<a> b = new ArrayList();

    public static b a(String str) {
        b bVar = new b();
        if (TextUtils.isEmpty(str)) {
            return bVar;
        }
        try {
            JSONObject jSONObject = new JSONObject(str);
            bVar.f431a = jSONObject.optInt("n", 0);
            int iOptInt = jSONObject.optInt("enc", 0);
            JSONArray jSONArrayOptJSONArray = jSONObject.optJSONArray(ClickCommon.CLICK_SCENE_AD);
            if (iOptInt == 1) {
                String strOptString = jSONObject.optString(ClickCommon.CLICK_SCENE_AD);
                if (!TextUtils.isEmpty(strOptString)) {
                    String strB = i.b(strOptString);
                    if (!TextUtils.isEmpty(strB)) {
                        jSONArrayOptJSONArray = new JSONArray(strB);
                    }
                }
            }
            bVar.b = a.a(jSONArrayOptJSONArray);
            return bVar;
        } catch (Throwable th) {
            th.printStackTrace();
            return bVar;
        }
    }

    public List<a> a() {
        return this.b;
    }
}
