package com.kwad.sdk.contentalliance.a.a;

import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.VideoPlayerStatus;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    public com.kwad.sdk.contentalliance.a.a.a aKM;
    public AdTemplate adTemplate;
    public boolean isNoCache;
    public String manifest;
    public VideoPlayerStatus videoPlayerStatus;
    public String videoUrl;

    /* synthetic */ b(a aVar, byte b) {
        this(aVar);
    }

    private b(a aVar) {
        this.aKM = new com.kwad.sdk.contentalliance.a.a.a();
        this.isNoCache = false;
        this.adTemplate = aVar.adTemplate;
        this.videoUrl = aVar.videoUrl;
        this.manifest = aVar.manifest;
        this.videoPlayerStatus = aVar.videoPlayerStatus;
        if (aVar.aKM != null) {
            this.aKM.photoId = aVar.aKM.photoId;
            this.aKM.clickTime = aVar.aKM.clickTime;
            this.aKM.adStyle = aVar.aKM.adStyle;
            this.aKM.contentType = aVar.aKM.contentType;
        }
        this.isNoCache = aVar.isNoCache;
    }

    public static class a {
        private com.kwad.sdk.contentalliance.a.a.a aKM;
        private AdTemplate adTemplate;
        private boolean isNoCache = false;
        private String manifest;
        private VideoPlayerStatus videoPlayerStatus;
        private String videoUrl;

        public a(AdTemplate adTemplate) {
            this.adTemplate = adTemplate;
        }

        public a(String str) {
            this.videoUrl = str;
        }

        public final a dO(String str) {
            this.videoUrl = str;
            return this;
        }

        public final a dP(String str) {
            this.manifest = str;
            return this;
        }

        public final a b(com.kwad.sdk.contentalliance.a.a.a aVar) {
            this.aKM = aVar;
            return this;
        }

        public final a a(VideoPlayerStatus videoPlayerStatus) {
            this.videoPlayerStatus = videoPlayerStatus;
            return this;
        }

        public final a bD(boolean z) {
            this.isNoCache = z;
            return this;
        }

        public final b IS() {
            return new b(this, (byte) 0);
        }
    }
}
