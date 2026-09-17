package com.unicom.online.account.kernel;

import android.content.Context;
import android.content.SharedPreferences;
import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.LiveConfigKey;
import java.util.ArrayList;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public abstract class bf {
    public static void b(Context context, ArrayList arrayList) {
        if (arrayList.size() == 0) {
            return;
        }
        try {
            JSONArray jSONArray = new JSONArray();
            for (int i = 0; i < arrayList.size(); i++) {
                t tVar = (t) arrayList.get(i);
                JSONObject jSONObject = new JSONObject();
                jSONObject.put("domain", tVar.b);
                jSONObject.put("port", tVar.c);
                jSONObject.put("ip", tVar.d);
                jSONObject.put("expire", tVar.e);
                jSONArray.put(jSONObject);
            }
            SharedPreferences.Editor editorEdit = context.getSharedPreferences("cu_auth", 0).edit();
            editorEdit.putString("DNSCache_TCP_V2.0", jSONArray.toString());
            editorEdit.apply();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static ArrayList b(Context context) {
        try {
            String string = context.getSharedPreferences("cu_auth", 0).getString("DNSCache_TCP_V2.0", null);
            ArrayList arrayList = new ArrayList();
            if (string != null && !string.isEmpty()) {
                JSONArray jSONArray = new JSONArray(string);
                for (int i = 0; i < jSONArray.length(); i++) {
                    JSONObject jSONObject = jSONArray.getJSONObject(i);
                    t tVar = new t();
                    tVar.b = jSONObject.optString("domain");
                    String strOptString = jSONObject.optString("port");
                    tVar.c = strOptString;
                    if (TextUtils.isEmpty(strOptString)) {
                        tVar.c = LiveConfigKey.DEFAULT_TLS_PORT;
                    } else {
                        try {
                            int i2 = Integer.parseInt(tVar.c);
                            if (i2 <= 0 || i2 > 65535) {
                                tVar.c = LiveConfigKey.DEFAULT_TLS_PORT;
                            }
                        } catch (NumberFormatException unused) {
                            tVar.c = LiveConfigKey.DEFAULT_TLS_PORT;
                        }
                    }
                    tVar.d = jSONObject.optString("ip");
                    tVar.e = jSONObject.optLong("expire");
                    arrayList.add(tVar);
                }
            }
            return arrayList;
        } catch (Exception e) {
            e.getMessage();
            e.printStackTrace();
            return new ArrayList();
        }
    }
}
