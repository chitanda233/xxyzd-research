package com.kwai.adclient.kscommerciallogger.snapshot;

import java.util.Iterator;
import java.util.LinkedList;
import java.util.Objects;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class c {
    private final String buT;
    private final LinkedList<d> buU;
    private int buV;
    private final int buW;
    private long buX;

    c(String str) {
        this(str, 10);
    }

    c(String str, int i) {
        this.buT = str == null ? "" : str;
        this.buU = new LinkedList<>();
        this.buW = Math.min(i, 30);
        this.buX = System.currentTimeMillis();
    }

    final String getName() {
        return this.buT;
    }

    synchronized JSONObject iG(String str) {
        JSONObject jSONObject;
        try {
            jSONObject = new JSONObject();
            try {
                JSONArray jSONArray = new JSONArray();
                Iterator<d> it = this.buU.iterator();
                while (it.hasNext()) {
                    jSONArray.put(it.next().Yx());
                }
                jSONObject.put("session_id", str);
                jSONObject.put("segment_name", this.buT);
                jSONObject.put("spans", jSONArray);
                this.buX = System.currentTimeMillis();
            } catch (JSONException e) {
                e.printStackTrace();
            }
        } catch (Throwable th) {
            throw th;
        }
        return jSONObject;
    }

    public synchronized d iF(String str) {
        d dVar;
        if (this.buU.size() >= this.buW) {
            this.buU.removeFirst();
        }
        StringBuilder sbAppend = new StringBuilder().append(str).append("_");
        int i = this.buV;
        this.buV = i + 1;
        dVar = new d(sbAppend.append(i).toString());
        this.buU.addLast(dVar);
        this.buX = System.currentTimeMillis();
        return dVar;
    }

    public final synchronized long Yy() {
        return this.buX;
    }

    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (obj == null || getClass() != obj.getClass()) {
            return false;
        }
        return this.buT.equals(((c) obj).buT);
    }

    public int hashCode() {
        return Objects.hash(this.buT);
    }
}
