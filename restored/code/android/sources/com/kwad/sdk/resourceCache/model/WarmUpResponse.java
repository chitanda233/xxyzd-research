package com.kwad.sdk.resourceCache.model;

import android.text.TextUtils;
import com.alipay.sdk.m.y.o;
import com.kwad.components.offline.api.tk.model.report.TKDownloadReason;
import com.kwad.sdk.components.d;
import com.kwad.sdk.core.a.e;
import com.kwad.sdk.core.b;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.response.model.BaseResultData;
import com.kwad.sdk.utils.ac;
import com.kwad.sdk.utils.br;
import java.io.Serializable;
import java.util.ArrayList;
import java.util.Iterator;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class WarmUpResponse extends BaseResultData implements Serializable {
    private static final long serialVersionUID = -3822162279240949932L;
    public boolean cleanResourceWarmup;
    public boolean disableImageWarmup;
    public boolean disableResourceWarmup;
    public boolean disableVideoWarmup;
    public boolean disableZipWarmup;
    public int minWarmupDiskSize;
    public WarmupVideos warmupVideos = new WarmupVideos();
    public WarmupImages warmupImages = new WarmupImages();
    public WarmupZips warmupZips = new WarmupZips();

    @Override // com.kwad.sdk.core.response.model.BaseResultData, com.kwad.sdk.core.b
    public void parseJson(JSONObject jSONObject) {
        super.parseJson(jSONObject);
        if (jSONObject == null) {
            return;
        }
        String strOptString = jSONObject.optString("data");
        e eVar = (e) d.f(e.class);
        if (br.isNullString(strOptString)) {
            return;
        }
        String responseData = eVar.getResponseData(strOptString);
        if (TextUtils.isEmpty(responseData)) {
            return;
        }
        try {
            JSONObject jSONObject2 = new JSONObject(responseData);
            this.disableResourceWarmup = jSONObject2.optBoolean("disableResourceWarmup");
            this.disableVideoWarmup = jSONObject2.optBoolean("disableVideoWarmup");
            this.disableImageWarmup = jSONObject2.optBoolean("disableImageWarmup");
            this.disableZipWarmup = jSONObject2.optBoolean("disableZipWarmup");
            this.minWarmupDiskSize = jSONObject2.optInt("minWarmupDiskSize");
            this.cleanResourceWarmup = jSONObject2.optBoolean("cleanResourceWarmup");
            JSONObject jSONObjectOptJSONObject = jSONObject2.optJSONObject("warmupVideos");
            if (jSONObjectOptJSONObject != null) {
                this.warmupVideos.parseJson(jSONObjectOptJSONObject);
            }
            JSONObject jSONObjectOptJSONObject2 = jSONObject2.optJSONObject("warmupImages");
            if (jSONObjectOptJSONObject2 != null) {
                this.warmupImages.parseJson(jSONObjectOptJSONObject2);
            }
            JSONObject jSONObjectOptJSONObject3 = jSONObject2.optJSONObject("warmupZips");
            if (jSONObjectOptJSONObject3 != null) {
                this.warmupZips.parseJson(jSONObjectOptJSONObject3);
            }
        } catch (JSONException e) {
            c.printStackTraceOnly(e);
        }
    }

    @Override // com.kwad.sdk.core.response.model.BaseResultData, com.kwad.sdk.core.b
    public JSONObject toJson() {
        JSONObject json = super.toJson();
        ac.putValue(json, o.c, this.result);
        ac.putValue(json, "disableResourceWarmup", this.disableResourceWarmup);
        ac.putValue(json, "disableVideoWarmup", this.disableVideoWarmup);
        ac.putValue(json, "disableImageWarmup", this.disableImageWarmup);
        ac.putValue(json, "disableZipWarmup", this.disableZipWarmup);
        ac.putValue(json, "minWarmupDiskSize", this.minWarmupDiskSize);
        ac.putValue(json, "cleanResourceWarmup", this.cleanResourceWarmup);
        ac.putValue(json, "warmupVideos", this.warmupVideos.toJson());
        ac.putValue(json, "warmupImages", this.warmupImages.toJson());
        ac.putValue(json, "warmupZips", this.warmupZips.toJson());
        return json;
    }

    public static class WarmupImages implements b, Serializable {
        private static final long serialVersionUID = 9116421028365391209L;
        public ArrayList<ResourceItem> images = new ArrayList<>();

        @Override // com.kwad.sdk.core.b
        public void parseJson(JSONObject jSONObject) {
            JSONArray jSONArrayOptJSONArray;
            if (jSONObject == null || (jSONArrayOptJSONArray = jSONObject.optJSONArray("images")) == null) {
                return;
            }
            this.images.clear();
            for (int i = 0; i < jSONArrayOptJSONArray.length(); i++) {
                ResourceItem resourceItem = new ResourceItem();
                resourceItem.parseJson(jSONArrayOptJSONArray.optJSONObject(i));
                this.images.add(resourceItem);
            }
        }

        @Override // com.kwad.sdk.core.b
        public JSONObject toJson() {
            JSONObject jSONObject = new JSONObject();
            JSONArray jSONArray = new JSONArray();
            Iterator<ResourceItem> it = this.images.iterator();
            while (it.hasNext()) {
                jSONArray.put(it.next().toJson());
            }
            ac.putValue(jSONObject, "images", jSONArray);
            return jSONObject;
        }
    }

    public static class WarmupZips implements b, Serializable {
        private static final long serialVersionUID = 6198220122324956576L;
        public ArrayList<ResourceItem> zips = new ArrayList<>();

        @Override // com.kwad.sdk.core.b
        public void parseJson(JSONObject jSONObject) {
            JSONArray jSONArrayOptJSONArray;
            if (jSONObject == null || (jSONArrayOptJSONArray = jSONObject.optJSONArray("zips")) == null) {
                return;
            }
            this.zips.clear();
            for (int i = 0; i < jSONArrayOptJSONArray.length(); i++) {
                ResourceItem resourceItem = new ResourceItem();
                resourceItem.parseJson(jSONArrayOptJSONArray.optJSONObject(i));
                this.zips.add(resourceItem);
            }
        }

        @Override // com.kwad.sdk.core.b
        public JSONObject toJson() {
            JSONObject jSONObject = new JSONObject();
            JSONArray jSONArray = new JSONArray();
            Iterator<ResourceItem> it = this.zips.iterator();
            while (it.hasNext()) {
                jSONArray.put(it.next().toJson());
            }
            ac.putValue(jSONObject, "zips", jSONArray);
            return jSONObject;
        }
    }

    public static class WarmupVideos implements b, Serializable {
        private static final long serialVersionUID = -5397366224830219648L;
        public ArrayList<ResourceItem> videos = new ArrayList<>();
        public boolean wifiOnly;

        @Override // com.kwad.sdk.core.b
        public void parseJson(JSONObject jSONObject) {
            if (jSONObject == null) {
                return;
            }
            this.wifiOnly = jSONObject.optBoolean("wifiOnly");
            JSONArray jSONArrayOptJSONArray = jSONObject.optJSONArray("videos");
            if (jSONArrayOptJSONArray != null) {
                this.videos.clear();
                for (int i = 0; i < jSONArrayOptJSONArray.length(); i++) {
                    ResourceItem resourceItem = new ResourceItem();
                    resourceItem.parseJson(jSONArrayOptJSONArray.optJSONObject(i));
                    this.videos.add(resourceItem);
                }
            }
        }

        @Override // com.kwad.sdk.core.b
        public JSONObject toJson() {
            JSONObject jSONObject = new JSONObject();
            JSONArray jSONArray = new JSONArray();
            Iterator<ResourceItem> it = this.videos.iterator();
            while (it.hasNext()) {
                jSONArray.put(it.next().toJson());
            }
            ac.putValue(jSONObject, "wifiOnly", this.wifiOnly);
            ac.putValue(jSONObject, "videos", jSONArray);
            return jSONObject;
        }
    }

    public static class ResourceItem implements b, Serializable {
        private static final long serialVersionUID = 7792858892044915778L;
        public String cachePath;
        public double downloadSize;
        public long endTime;
        public boolean isCached = false;
        public boolean isZip = false;
        public String md5;
        public int priority;
        public String resourceKey;
        public String url;
        public String zipDir;

        @Override // com.kwad.sdk.core.b
        public void parseJson(JSONObject jSONObject) {
            if (jSONObject == null) {
                return;
            }
            this.resourceKey = jSONObject.optString("resourceKey");
            this.priority = jSONObject.optInt("priority");
            this.downloadSize = jSONObject.optDouble("downloadSize", 0.0d);
            this.url = jSONObject.optString("url");
            this.md5 = jSONObject.optString(TKDownloadReason.KSAD_TK_MD5);
            this.endTime = jSONObject.optLong("endTime");
            this.cachePath = jSONObject.optString("cachePath");
            this.isCached = jSONObject.optBoolean("isCached");
            this.isZip = jSONObject.optBoolean("isZip");
            this.zipDir = jSONObject.optString("zipDir");
        }

        @Override // com.kwad.sdk.core.b
        public JSONObject toJson() {
            JSONObject jSONObject = new JSONObject();
            ac.putValue(jSONObject, "resourceKey", this.resourceKey);
            ac.putValue(jSONObject, "priority", this.priority);
            ac.putValue(jSONObject, "downloadSize", this.downloadSize);
            ac.putValue(jSONObject, "url", this.url);
            ac.putValue(jSONObject, TKDownloadReason.KSAD_TK_MD5, this.md5);
            ac.putValue(jSONObject, "endTime", this.endTime);
            ac.putValue(jSONObject, "cachePath", this.cachePath);
            ac.putValue(jSONObject, "isCached", this.isCached);
            ac.putValue(jSONObject, "isZip", this.isZip);
            ac.putValue(jSONObject, "zipDir", this.zipDir);
            return jSONObject;
        }
    }
}
