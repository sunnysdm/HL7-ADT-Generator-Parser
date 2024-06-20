﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Model.HL7.ADT.TransferPatient_A02.TranserPatient_Segment_A02
{
    public class OBXSegment_A02
    {
        public string? OBX1_SetIdObx { get; set; } // Optional
        public string? OBX2_ValueType { get; set; } // Conditional
        public string? OBX3_ObservationIdentifier { get; set; } // Required
        public string? OBX4_ObservationSubId { get; set; } // Conditional
        public List<string> OBX5_ObservationValue { get; set; } // Conditional, Repeatable
        public string? OBX6_Units { get; set; } // Optional
        public string? OBX7_ReferencesRange { get; set; } // Optional
        public List<string>? OBX8_InterpretationCodes { get; set; } // Optional, Repeatable
        public string? OBX9_Probability { get; set; } // Optional
        public List<string>? OBX10_NatureOfAbnormalTest { get; set; } // Optional, Repeatable
        public string? OBX11_ObservationResultStatus { get; set; } // Required
        public string? OBX12_EffectiveDateOfReferenceRange { get; set; } // Optional
        public string? OBX13_UserDefinedAccessChecks { get; set; } // Optional
        public string? OBX14_DateTimeOfTheObservation { get; set; } // Optional
        public string? OBX15_ProducersId { get; set; } // Optional
        public List<string>? OBX16_ResponsibleObserver { get; set; } // Optional, Repeatable
        public List<string>? OBX17_ObservationMethod { get; set; } // Optional, Repeatable
        public List<string>? OBX18_EquipmentInstanceIdentifier { get; set; } // Optional, Repeatable
        public string? OBX19_DateTimeOfTheAnalysis { get; set; } // Optional
        public List<string>? OBX20_ObservationSite { get; set; } // Optional, Repeatable
        public string? OBX21_ObservationInstanceIdentifier { get; set; } // Optional
        public string? OBX22_MoodCode { get; set; } // Conditional
                                                    // Fields OBX23 to OBX25 are marked as Optional but are typically used in specific contexts
        public string? OBX23_PerformingOrganizationName { get; set; } // Optional
        public string? OBX24_PerformingOrganizationAddress { get; set; } // Optional
        public string? OBX25_PerformingOrganizationMedicalDirector { get; set; } // Optional
        public string? OBX26_PatientResultsReleaseCategory { get; set; } // Optional
        public string? OBX27_RootCause { get; set; } // Optional
        public List<string>? OBX28_LocalProcessControl { get; set; } // Optional, Repeatable

    }
    }
