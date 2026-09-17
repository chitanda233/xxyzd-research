package cn.com.chinatelecom.account.api.utils;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class JsonToHashMap {
    public static HashMap<String, Object> jsonToHashMap(JSONObject jSONObject) throws JSONException {
        return jSONObject != JSONObject.NULL ? toHashMap(jSONObject) : new HashMap<>();
    }

    public static HashMap<String, Object> toHashMap(JSONObject jSONObject) throws JSONException {
        HashMap<String, Object> map = new HashMap<>();
        Iterator<String> itKeys = jSONObject.keys();
        while (itKeys.hasNext()) {
            String next = itKeys.next();
            Object hashMap = jSONObject.get(next);
            if (hashMap instanceof JSONArray) {
                hashMap = toList((JSONArray) hashMap);
            } else if (hashMap instanceof JSONObject) {
                hashMap = toHashMap((JSONObject) hashMap);
            }
            map.put(next, hashMap);
        }
        return map;
    }

    public static List<Object> toList(JSONArray jSONArray) throws JSONException {
        ArrayList arrayList = new ArrayList();
        for (int i = 0; i < jSONArray.length(); i++) {
            Object hashMap = jSONArray.get(i);
            if (hashMap instanceof JSONArray) {
                hashMap = toList((JSONArray) hashMap);
            } else if (hashMap instanceof JSONObject) {
                hashMap = toHashMap((JSONObject) hashMap);
            }
            arrayList.add(hashMap);
        }
        return arrayList;
    }
}
