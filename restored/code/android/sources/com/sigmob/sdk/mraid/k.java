package com.sigmob.sdk.mraid;

import com.sigmob.sdk.base.models.PlacementType;

/* JADX INFO: loaded from: classes3.dex */
public enum k {
    CLOSE("close"),
    EXPAND("expand") { // from class: com.sigmob.sdk.mraid.k.1
        @Override // com.sigmob.sdk.mraid.k
        boolean a(final PlacementType placementType) {
            return placementType == PlacementType.INLINE;
        }
    },
    USE_CUSTOM_CLOSE("usecustomclose"),
    OPEN("open") { // from class: com.sigmob.sdk.mraid.k.2
        @Override // com.sigmob.sdk.mraid.k
        boolean a(final PlacementType placementType) {
            return true;
        }
    },
    feedBack("feedback") { // from class: com.sigmob.sdk.mraid.k.3
        @Override // com.sigmob.sdk.mraid.k
        boolean a(final PlacementType placementType) {
            return true;
        }
    },
    UNLOAD("unload"),
    OPENFOURELEMENTS("openFourElements"),
    RESIZE("resize") { // from class: com.sigmob.sdk.mraid.k.4
        @Override // com.sigmob.sdk.mraid.k
        boolean a(final PlacementType placementType) {
            return true;
        }
    },
    SET_ORIENTATION_PROPERTIES("setOrientationProperties"),
    PLAY_VIDEO("playVideo") { // from class: com.sigmob.sdk.mraid.k.5
        @Override // com.sigmob.sdk.mraid.k
        boolean a(final PlacementType placementType) {
            return placementType == PlacementType.INLINE;
        }
    },
    STORE_PICTURE("storePicture") { // from class: com.sigmob.sdk.mraid.k.6
        @Override // com.sigmob.sdk.mraid.k
        boolean a(final PlacementType placementType) {
            return true;
        }
    },
    CREATE_CALENDAR_EVENT("createCalendarEvent") { // from class: com.sigmob.sdk.mraid.k.7
        @Override // com.sigmob.sdk.mraid.k
        boolean a(final PlacementType placementType) {
            return true;
        }
    },
    VPAID("vpaid") { // from class: com.sigmob.sdk.mraid.k.8
        @Override // com.sigmob.sdk.mraid.k
        boolean a(final PlacementType placementType) {
            return true;
        }
    },
    EXTENSION("extension") { // from class: com.sigmob.sdk.mraid.k.9
        @Override // com.sigmob.sdk.mraid.k
        boolean a(final PlacementType placementType) {
            return true;
        }
    },
    UNSPECIFIED("");

    private final String p;

    k(String javascriptString) {
        this.p = javascriptString;
    }

    public static k a(String string) {
        for (k kVar : values()) {
            if (kVar.p.equals(string)) {
                return kVar;
            }
        }
        return UNSPECIFIED;
    }

    public String a() {
        return this.p;
    }

    boolean a(PlacementType placementType) {
        return false;
    }
}
